package shootinggame;

import java.awt.Graphics;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class EnemyShot extends Shot{

    public EnemyShot(int x, int y){
       super(x, y);
    }
    
    public void moveShot(int speed){
        super.x_pos -= speed;
        if(super.x_pos<-20)
            super.alive=false;
    }
    
    public void drawShot(Graphics g){
        File sourceimage = new File("res/character/bullet2.png");
        Image img = null;
		try {
			img = ImageIO.read(sourceimage);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
                g.drawImage(img, (int)x_pos+10, (int)y_pos+20, 40, 25, null);
    }
}
