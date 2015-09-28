package shootinggame;

import java.awt.Graphics;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class Player {
    protected int x_pos;
    protected int y_pos;
    protected int min_x;
    protected int max_x;
    protected int min_y;
    protected int max_y;

    public Player(int x, int y, int min_x, int max_x,int min_y, int max_y) {
        x_pos = x;
        y_pos = y;
        this.min_x = min_x;
        this.max_x = max_x;
        this.min_y = min_y;
        this.max_y = max_y;
    }

    public void moveX(int speed) {
        x_pos += speed;
        if( x_pos < min_x) x_pos = min_x;
        if( x_pos > max_x) x_pos = max_x;
    }
    public void moveY(int speed) {
        y_pos += speed;
        if( y_pos < min_y) y_pos = min_y;
        if( y_pos > max_y) y_pos = max_y;
    }
    public int getX() {
        return x_pos;
    }

    public int getY() {
        return y_pos;
    }
    
    public int getMinX() {
        return min_x;
    }
    
    public int getMaxX() {
        return max_x;
    }
    
    public int getMinY() {
        return min_y;
    }
    
    public int getMaxY() {
        return max_y;
    }
    
    public Shot generateShot(int y) {
        Shot shot = new Shot(x_pos, y_pos+y);
        return shot;
    }

    public void drawPlayer(Graphics g) {
        File sourceimage = new File("res/character/player4.png");
        Image img = null;
		try {
			img = ImageIO.read(sourceimage);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
                g.drawImage(img, x_pos, y_pos, 80, 40, null);
    }
}
