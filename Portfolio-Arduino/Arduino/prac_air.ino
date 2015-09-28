#include <IRremote.h>
#include <IRremoteInt.h>
#include <WiFi.h>
#include <SPI.h>
#include <dht.h>

/* About pin number
 * if you want another pin number,
 * you could change define number
 * NOTE : pin number must equal the connection pin number 
 * Used pin
 * 0, 1 : RX, TX
 * 4 : SS for SD card
 * 7 : Handshake between shield and Arduino
 * 10 : SS for WiFi
 * 11 : MOSI
 * 12 : MISO
 * 13 : SCK
 * 2, 3, 5, 6, 8, 9 : Not used pin number
 */
#define DHT_PIN 5

char hexval[16] = {'0', '1', '2', '3', '4', '5', '6',
  '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
char ssid[] = "diana";
char pass[] = "flcl1300";
int cntSSID, flagStr = 0;
int status = WL_IDLE_STATUS;
char server[] = "210.125.31.146";
char server_inner[] = "192.168.123.123";
WiFiClient wifiClient;
String buffer, macAddr;
byte mac[6];
char mac_string[13];
dht DHT;
IRsend irsend;

void setup() {
  Serial.begin(9600);
  
  if (WiFi.status() == WL_NO_SHIELD) {
    Serial.println("WiFi shield not present"); 
    // don't continue:
    while(true);
  }
  
  String fv = WiFi.firmwareVersion();
  Serial.println("Firmware Version = " + fv);
  
  cntSSID = WiFi.scanNetworks();
  if(cntSSID == -1){
    Serial.println("Couldn't get a wifi connection");
    while(true);
  }
  
  int i=0;
  /*
  while (status != WL_CONNECTED && i<cntSSID) {  
    Serial.print("Attempting to connect to SSID: ");
    Serial.println(WiFi.SSID(i));
    
    switch(WiFi.encryptionType(i)){
      case ENC_TYPE_NONE:
        status = WiFi.begin(WiFi.SSID(i));
        break;
      case ENC_TYPE_CCMP:
        status = WiFi.begin(WiFi.SSID(i), pass);
        break;
      default:
        break;
    }
    
    i++;
    
    if(i>9)
      i=0;
    

    // wait 3 seconds for connection:
    delay(3000);
  }
  */
  
  while ( status != WL_CONNECTED) { 
    Serial.print("Attempting to connect to open SSID: ");
    Serial.println(ssid);
    status = WiFi.begin(ssid, pass);

    // wait 10 seconds for connection:
    delay(1000);
  }
  
  Serial.println("WiFi Connection Success!!");
  
  WiFi.macAddress(mac);
  for(int j=0;j<6;j++){
    mac_string[j*2] = hexval[((mac[5-j]>>4) & 0xF)];
    mac_string[(j*2)+1] = hexval[((mac[5-j]) & 0x0F)];
  }
  mac_string[13] = 0;
  macAddr = mac_string;
  Serial.println(macAddr);
  
  if(wifiClient.connect(server, 80)){
    Serial.println("Server Connection Success");
    delay(1000);
  }
  else{
    Serial.println("Server Connection fail");
    while(true);
  }
}

void loop() {
  String data;
  
  if(wifiClient.connected()){
    if(wifiClient.available() > 0){
      char c = wifiClient.read();
      Serial.print(c);
      if(c == '@' && flagStr == 0){
        buffer = "@";
        flagStr = 1;
      }
      if(flagStr == 1){
        delay(500);
        while(wifiClient.available()>0){
          char ch = wifiClient.read();
          Serial.print(ch);
          buffer += ch;
          if(ch == '@' && flagStr == 1){
            data = protocol(buffer);
            Serial.println(data);
                                                                                                                                                                               wifiClient.print(data);
            flagStr = 0;
            break;
          }
        }
      }
    }
  }
  
  delay(500);
}

/* Arduino Protocol 
 * Format : @/<RX_NAME>/<TX_NAME>/<INSTR1>/<INSTR2>/arg1/arg2/arg3/@
 * if arg==NULL then insert ^
 * <RX_NAME> : source node
 * <TX_NAME> : destination node
 * <INSTR1> : C, S, P(control, Sensor, resPonse)
 * <INSTR2> : item or judgement
 * (C : F(fan), A(air conditioner) //Appliance)
 * (P : S, F, M(success, fail, mesasurement))
 * arg1 : function or item
 * (A : 0 == on/off, 1 == up, 2 == down, 3 == indensity, 4 == mode, 5 == time
 * 6 : sleep)
 * (F : 0 == on/off, 1 == indensity, 2 == nature, 3 == time, 4 == rotation,
 * 5 == lamp)
 * (S : T == temperature, H == humidity, E == electricity)
 * return : string (@/<RX_NAME>/mac_string/P/<INSTR2>/^/^/^/@)
 */
String protocol(String msg){
  char temp[128];
  String source, m;
  char *token;
  int flag = 0, flag_arg = 0;
  int fan_function = -1;
  int air_function = -1;
  int sensor_function = -1;
  int time;
  
  strcpy(temp, msg.c_str());
  //@
  token = strtok(temp, "/");
  if(strcmp(token, "@")==0){
    //<RX_NAME>
    token = strtok(NULL, "/");
    if(strcmp(token, mac_string)==0){
      //<TX_NAME>
      token = strtok(NULL, "/");
      source = token;
      //<INSTR1>
      token = strtok(NULL, "/");
      if(strcmp(token, "C")==0){
        //<INSTR2>
        token = strtok(NULL, "/");
        if(strcmp(token, "A")==0){
          //<arg1>
          token = strtok(NULL, "/");
          if(strcmp(token, "0")==0){
            air_function = 0;
            flag_arg = 1;
          }
          else if(strcmp(token, "1")==0){
            air_function = 1;
            flag_arg = 1;
          }
          else if(strcmp(token, "2")==0){
            air_function = 2;
            flag_arg = 1;
          }
          else if(strcmp(token, "3")==0){
            air_function = 3;
            flag_arg = 1;
          }
          else if(strcmp(token, "4")==0){
            air_function = 4;
            flag_arg = 1;
          }
          else if(strcmp(token, "5")==0){
            air_function = 5;
            flag_arg = 1;
          }
          else if(strcmp(token, "6")==0){
            air_function = 6;
            flag_arg = 1;
          }
          //not arg1
          else{
            flag = 0;
          }
          //arg2
          if(flag_arg == 1){
            token = strtok(NULL, "/");
            if(strcmp(token, "^")==0){
              //arg3
              token = strtok(NULL, "/");
              if(strcmp(token, "^")==0){
                //@
                token = strtok(NULL, "/");
                if(strcmp(token, "@")==0){
                  flag = 1;
                }
                //not @
                else{
                  air_function = -1;
                  flag = 0 ;
                }
              }
              //not arg3
              else{
                air_function = -1;
                flag = 0;
              }
            }
            //not arg2
            else{
              air_function = -1;
              flag = 0;
            }
          }
        }
        //F
        else if(strcmp(token, "F")==0){
          //<arg1>
          token = strtok(NULL, "/");
          if(strcmp(token, "0")==0){
            fan_function = 0;
            flag_arg = 1;
          }
          else if(strcmp(token, "1")==0){
            fan_function = 1;
            flag_arg = 1;
          }
          else if(strcmp(token, "2")==0){
            fan_function = 2;
            flag_arg = 1;
          }
          else if(strcmp(token, "3")==0){
            fan_function = 3;
            flag_arg = 1;
          }
          else if(strcmp(token, "4")==0){
            fan_function = 4;
            flag_arg = 1;
          }
          else if(strcmp(token, "5")==0){
            fan_function = 5;
            flag_arg = 1;
          }
          //not arg1
          else{
            flag = 0;
          }
          //arg2
          if(flag_arg == 1){
            token = strtok(NULL, "/");
            if(strcmp(token, "^")==0){
              //arg3
              token = strtok(NULL, "/");
              if(strcmp(token, "^")==0){
                //@
                token = strtok(NULL, "/");
                if(strcmp(token, "@")==0){
                  flag = 1;
                }
                //not @
                else{
                  fan_function = -1;
                  flag = 0 ;
                }
              }
              //not arg3
              else{
                fan_function = -1;
                flag = 0;
              }
            }
            //not arg2
            else{
              fan_function = -1;
              flag = 0;
            }
          }
        }
        //not <INSTR2>
        else{
          flag = 0;
        }
      }
      else if(strcmp(token, "S")==0){
        //<INSTR2>
        token = strtok(NULL, "/");
        if(strcmp(token, "F")==0){
          //arg1
          token = strtok(NULL, "/");
          if(strcmp(token, "T")==0){
            sensor_function = 0;
            flag_arg = 1;
          }
          else if(strcmp(token, "H")==0){
            sensor_function = 1;
            flag_arg = 1;
          }
          else if(strcmp(token, "E")==0){
            sensor_function = 2;
            flag_arg = 1;
          }
          //not arg1
          else{
            flag = 0;
          }
          //arg2
          if(flag_arg == 1){
            token = strtok(NULL, "/");
            if(strcmp(token, "^")==0){
              //arg3
              token = strtok(NULL, "/");
              if(strcmp(token, "^")==0){
                //@
                token = strtok(NULL, "/");
                if(strcmp(token, "@")==0){
                  flag = 1;
                }
                //not @
                else{
                  sensor_function = -1;
                  flag = 0 ;
                }
              }
              //not arg3
              else{
                sensor_function = -1;
                flag = 0;
              }
            }
            //not arg2
            else{
              sensor_function = -1;
              flag = 0;
            }
          }
        }
        //not <INSTR2>
        else{
          flag = 0;
        }
      }
      //not <INSTR1>
      else{
        flag = 0;
      }
    }
    //not mine
    else{
      flag = 0;
    }
  }
  //not '@'
  else{
    flag = 0;
  }
  
  if(flag==1){
    if(air_function>-1){
      switch(air_function){
        case 0:
          irsend.sendNEC(0x01FE39C6, 32);
          break;
        case 1:
          irsend.sendNEC(0x01FE29D6, 32);
          break;
        case 2:
          irsend.sendNEC(0x01FEA956, 32);
          break;
        case 3:
          irsend.sendNEC(0x01FE6996, 32);
          break;
        case 4:
          irsend.sendNEC(0x01FEB946, 32);
          break;
        case 5:
          irsend.sendNEC(0x01FEF906, 32);
          break;
        case 6:
          irsend.sendNEC(0x01FED926, 32);
          break;
        default:
          break;
      }
      return "@/" + source + "/" + macAddr + "/P/S/^/^/^/@";
    }
    else if(fan_function>-1){
      switch(fan_function){
        case 0:
          irsend.sendMY_FAN(0x534AAB, 23);
          irsend.sendMY_FAN(0x534AAB, 23);
          break;
        case 1:
          irsend.sendMY_FAN(0x534AAC, 23);
          irsend.sendMY_FAN(0x534AAC, 23);
          break;
        case 2:
          irsend.sendMY_FAN(0x534AB2, 23);
          irsend.sendMY_FAN(0x534AB2, 23);
          break;
        case 3:
          irsend.sendMY_FAN(0x534ACA, 23);
          irsend.sendMY_FAN(0x534ACA, 23);
          break;
        case 4:
          irsend.sendMY_FAN(0x534CAA, 23);
          irsend.sendMY_FAN(0x534CAA, 23);
          break;
        case 5:
          irsend.sendMY_FAN(0x534B2A, 23);
          irsend.sendMY_FAN(0x534B2A, 23);
          break;
        default:
          break;
      }
      return "@/" + source + "/" + macAddr + "/P/S/^/^/^/@";
    }
    else if(sensor_function>-1){
      DHT.read(DHT_PIN);
      switch(sensor_function){
        case 0:
          m = String((int)DHT.temperature);
          break;
        case 1:
          m = String((int)DHT.humidity);
          break;
        case 2:
          break;
        default:
          break;
      }
      return "@/" + source + "/" + macAddr + "/P/S/^/^/^/@";
    }
  }
  else{
    return "@/" + source + "/" + macAddr + "/P/F/^/^/^/@";
  }
}

