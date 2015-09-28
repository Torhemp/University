package shootinggame;

import java.awt.Graphics;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class Item {

    private float x_pos;
    private float y_pos;
    private float delta_x;
    private final int collision_distance_x_player = 60;
    private final int collision_distance_y_player = 30;
    private final int collision_distance_x_item = 40;
    private final int collision_distance_y_item = 30;

    public Item(int x, int y, float delta_x) {
        x_pos = x;
        y_pos = y;
        this.delta_x = delta_x;
    }

    public void move() {
        x_pos -= delta_x;
        delta_x += 0.02;
    }

    public float getX(){
        return x_pos;
    }
    public boolean isCollidedWithPlayer(Player player) {
        if (-collision_distance_y_item <= (y_pos - player.getY()) && (y_pos - player.getY() <= collision_distance_y_player)) {
            if (-collision_distance_x_item <= (x_pos - player.getX()) && (x_pos - player.getX() <= collision_distance_x_player)) {
                //collided.
                return true;
            }
        }
        return false;
    }

    public void draw(Graphics g) {
        File sourceimage = new File("res/character/item1.png");
        Image img = null;
		try {
			img = ImageIO.read(sourceimage);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
                g.drawImage(img, (int)x_pos, (int)y_pos, 30, 30,null);
                return;
    }
}
