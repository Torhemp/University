package shootinggame;

import java.awt.Graphics;
import java.awt.Color;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class Shot {

    public float x_pos;
    public float y_pos;
    public boolean alive;
    public final int radius = 3;
    private final int eRadius = 5;
    private int mEffect=10;
    private int cEffect=0;
    private final int collision_distance_x_shot = 40;
    private final int collision_distance_y_shot = 30;
    private final int collision_distance_x_player = 35;
    private final int collision_distance_y_player = 5;

    public Shot(int x, int y) {
        x_pos = x;
        y_pos = y;
        alive = true;
    }

    public float getY() {
        return y_pos;
    }

    public float getX() {
        return x_pos;
    }

    public void moveShot(int speed) {
        x_pos += speed;
    }

    public void drawShot(Graphics g) {
        if (!alive) {
        	if(cEffect<=mEffect) {
        		g.setColor(Color.red);
        		g.fillOval((int)x_pos-cEffect*eRadius/2+20, (int)y_pos-cEffect*eRadius/2+40, cEffect*eRadius, cEffect*eRadius);
        		cEffect++;
        	}
            return;
        }
        File sourceimage = new File("res/character/bullet1.png");
        Image img = null;
		try {
			img = ImageIO.read(sourceimage);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
                g.drawImage(img, (int)x_pos+50, (int)y_pos+20, 40, 18,null);
                return;
    }
    
    public boolean isAlive(){
        return alive;
    }

    public void collided() {
        alive = false;
    }
    
    public boolean isCollidedWithPlayer(Player player) {
        if (-collision_distance_y_shot <= (y_pos - player.getY()) && (y_pos - player.getY() <= collision_distance_y_player)) {
            if (-collision_distance_x_shot <= (x_pos - player.getX()) && (x_pos - player.getX() <= collision_distance_x_player)) {
                //collided.
                return true;
            }
        }
        return false;
    }
}
