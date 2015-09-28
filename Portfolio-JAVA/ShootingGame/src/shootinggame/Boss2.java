package shootinggame;

import java.awt.Graphics;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class Boss2 extends Boss {
    
    public Boss2(int x, int y, float delta_x, float delta_y, int max_x, int max_y){
        super(x, y, delta_x, delta_y, max_x, max_y);
        super.HP=50;
        this.alive = true;
    }
    public void draw(Graphics g) {
        File sourceimage = new File("res/character/boss2.png");
        Image img = null;
		try {
			img = ImageIO.read(sourceimage);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
                g.drawImage(img, (int)super.getX(), (int)super.getY(), 200, 100, null);
    }
}
