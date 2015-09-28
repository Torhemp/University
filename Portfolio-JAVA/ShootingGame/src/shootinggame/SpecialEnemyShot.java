package shootinggame;
import java.awt.Graphics;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class SpecialEnemyShot extends EnemyShot {
    private int[] shotCount_x;
    private int[] shotCount_y;
    private boolean[] shotCount_alive;
    private int check;
    private final int collision_distance_x_shot = 10;
    private final int collision_distance_y_shot = 10;
    private final int collision_distance_x_player = 60;
    private final int collision_distance_y_player = 25;
    
    public SpecialEnemyShot(int x, int y){
        super(x, y);
        shotCount_x = new int[8];
        shotCount_y = new int[8];
        shotCount_alive = new boolean [8];
        for(int i=0;i<8;++i){
            shotCount_x[i]=(int)super.x_pos;
            shotCount_alive[i]=true;
        }
        for(int i=0;i<8;++i){
            shotCount_y[i]=(int)super.y_pos;
        }
    }
    public void moveShot(int speed){
        for(int i=0;i<8;++i){
            if(shotCount_alive[i]){
                shotCount_x[i]-=speed*Math.cos(Math.toRadians(i*45));
                if(shotCount_x[i]<-100 || shotCount_x[i]>1500)
                    shotCount_alive[i]=false;
            }
        }
        for(int i=0;i<8;++i){
            if(shotCount_alive[i]){
                shotCount_y[i]+=speed*Math.sin(Math.toRadians(i*45));
                if(shotCount_y[i]<-75 || shotCount_y[i]>1000)
                    shotCount_alive[i]=false;
            }
         }
    }
    public void drawShot(Graphics g){
        for(int i=0;i<8;++i){
                File sourceimage = new File("res/character/bullet3.png");
                Image img = null;
		try {
			img = ImageIO.read(sourceimage);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
                g.drawImage(img, shotCount_x[i]+20, shotCount_y[i]+40 , 10, 10,null);
        }
        
    }
    public void checkAlive(){
        for(int i=0;i<8;++i){
            if(shotCount_alive[i]==false){
                shotCount_x[i]=1000;
                shotCount_y[i]=1000;
            }
        }
        for(boolean i : shotCount_alive){
            if(i==false)
                ++check;
        }
        if(check==7)
            super.alive=false;
        check=0;
    }
    public boolean isCollidedWithPlayer(Player player) {
        for(int i=0;i<8;++i){
            if (-collision_distance_y_shot <= (shotCount_y[i] - player.getY()+40) && (shotCount_y[i] - player.getY()+40 <= collision_distance_y_player)) {
                if (-collision_distance_x_shot <= (shotCount_x[i] - player.getX()+20) && (shotCount_x[i] - player.getX()+20 <= collision_distance_x_player)) {
                    shotCount_alive[i]=false;
                    return true;
                }
            }
        }
        return false;
    }
}
