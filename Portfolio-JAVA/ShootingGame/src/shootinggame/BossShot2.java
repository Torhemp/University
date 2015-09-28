package shootinggame;

import java.awt.Graphics;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class BossShot2 extends EnemyShot {
    public int pattern;
    public double radian;
    public int player_x;
    public int player_y;
    public double distance_x;
    public double distance_y;
    public float delta_x=(float)(Math.random()*3);
    public float delta_y=(float)(Math.random()*3);
    public boolean upDown;
    private final int collision_distance_x_shot = 10;
    private final int collision_distance_y_shot = 10;
    private final int collision_distance_x_player = 60;
    private final int collision_distance_y_player = 25;
    public BossShot2(int x, int y, int pattern, int angle, int player_x, int player_y, boolean upDown){
        super(x, y);
        this.pattern=pattern;     
        this.radian=Math.toRadians(angle);
        this.player_x=player_x;
        this.player_y=player_y;
        distance_x=x_pos-player_x+90;
        distance_y=y_pos-player_y+20;
        this.upDown=upDown;
    }
    
    public void moveShot(){
        switch(pattern){
        case 0:
            if((distance_x)>=-0.5 && (distance_x)<0.5){
                if((distance_y)>=0)
                    super.y_pos-=4;
                else
                    super.y_pos+=4;
            }
            else if(distance_x<0){
                super.x_pos+=4*Math.cos(Math.atan((distance_y)/(distance_x)));
                super.y_pos+=4*Math.sin(Math.atan((distance_y)/(distance_x)));
            } 
            else{
                super.x_pos-=4*Math.cos(Math.atan((distance_y)/(distance_x)));
                super.y_pos-=4*Math.sin(Math.atan((distance_y)/(distance_x)));
            }
            if(super.x_pos<=-50 || super.x_pos>=850)
                super.alive=false;
            if(super.y_pos<=-100 || super.y_pos>=800)
                super.alive=false;
            break;
        case 1:
            if(upDown)
                super.y_pos+=delta_y;
            else
                super.y_pos-=delta_y;
            if(super.x_pos<=-50 || super.x_pos>=850)
                super.alive=false;
            if(super.y_pos<=-100 || super.y_pos>=800)
                super.alive=false;
            break;
        case 2:
            if((distance_x)>=0)
                super.x_pos-=delta_x;
            else
                super.x_pos+=delta_x;
            if(super.x_pos<=-50 || super.x_pos>=850)
                super.alive=false;
            if(super.y_pos<=-100 || super.y_pos>=800)
                super.alive=false;
            break;
        }
    }
    public void drawShot(Graphics g){
        File sourceimage = new File("res/character/bullet3.png");
        Image img = null;
		try {
			img = ImageIO.read(sourceimage);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
                g.drawImage(img, (int)super.getX()+30, (int)super.getY()+30, 10, 10, null);
    }
    public boolean isCollidedWithPlayer(Player player) {
       if (-collision_distance_y_shot <= (super.getY() - player.getY()+30) && (super.getY() - player.getY()+30 <= collision_distance_y_player)) {
           if (-collision_distance_x_shot <= (super.getX() - player.getX()+30) && (super.getX() - player.getX()+30 <= collision_distance_x_player)) {
               return true;
           }
       }
       return false;
    }
}
