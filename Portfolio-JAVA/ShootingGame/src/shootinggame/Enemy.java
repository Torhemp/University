package shootinggame;

import java.awt.Graphics;
import java.awt.Image;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;

public class Enemy {

    private float x_pos;
    private float y_pos;
    private float delta_x;
    private float delta_y;
    private int max_x;
    private int max_y;
    private float delta_x_inc;
    private final int collision_distance_x_shot = 35;
    private final int collision_distance_y_shot = 20;
    private final int collision_distance_x_player = 60;
    private final int collision_distance_y_player = 40;
    private final int collision_distance_x_enemy = 60;
    private final int collision_distance_y_enemy = 40;
    private int movetype;
    public int HP;
    private int width;

    public Enemy(int x, int y, float delta_x, float delta_y, int max_x, int max_y, float delta_x_inc, int movetype) {
        x_pos = x;
        y_pos = y;
        this.delta_x = delta_x;
        this.delta_y = delta_y;
        this.max_x = max_x;
        this.max_y = max_y;
        this.delta_x_inc = delta_x_inc;
        this.movetype = movetype;
        this.HP = 5;
        width = x;
    }

    public void move() {
        switch (movetype)
        {
            case 0: // 지그재그
                x_pos -= delta_x;
                y_pos += delta_y;

                if (y_pos < 0) {
                    y_pos = 0;
                    delta_y = -delta_y;
                } else if (y_pos > max_y-30) {
                    y_pos = max_y-30;
                    delta_y = -delta_y;
                }
                if (x_pos < 0) {
                    x_pos = max_x;
                    delta_x += delta_x_inc;
                }
                break;
            case 1: // 떨어지는 <-  
                x_pos -= delta_x;
                break;
            case 2: // 상하
                y_pos -= delta_y;
                x_pos -= delta_x;
                if(x_pos<max_x-70)
                    delta_x=0;
                if(y_pos <0) {
                    y_pos = 0;
                    delta_y = -delta_y;
                } else if(y_pos > max_y-30){
                    y_pos= max_y-30;
                    delta_y = -delta_y;
                }
                break;
            case 3: // 좌우
                x_pos-=delta_x;
                if(x_pos < (max_x/3)){
                    x_pos = max_x/3;
                    delta_x = -delta_x;
                }else if (x_pos > max_x-30){
                    x_pos = max_x-30;
                    delta_x = -delta_x;
                }
                break;
            case 4: // 화면 반에서 꺾이는 movetype
                x_pos -= delta_x;
                if(x_pos < max_x/2){
                    x_pos -= delta_x;
                    y_pos -=delta_y;
                } else if (y_pos > max_y){
                    y_pos = max_y;
                    x_pos -= delta_x;
                } else if (y_pos <0){
                    y_pos = 0;
                    x_pos -= delta_x;
                }
                break;
            case 5:
                x_pos -= delta_x;
                y_pos += delta_y;
                if(y_pos < 0){
                    delta_x = -delta_x;
                    delta_y = -delta_y;
                } else if (y_pos > max_y){
                    delta_x = -delta_x;
                    delta_y = -delta_y;
                } else if(x_pos >max_x){
                    delta_x = -delta_x;
                    delta_y = -delta_y;
                }
                if (x_pos < 0) {
                    x_pos = max_x;
                    delta_x += delta_x_inc;
                }
                break;
            case 6:
                if(x_pos>width*(0.5))
                    x_pos -= delta_x;
            case 7:
                x_pos -= delta_x;
                y_pos += delta_y;

                if (y_pos < 0) {
                    y_pos = 0;
                    delta_y = -delta_y;
                } else if (y_pos > max_y-100) {
                    y_pos = max_y-100;
                    delta_y = -delta_y;
                }
                if (x_pos < 0) {
                    x_pos = 0;
                    delta_x = -delta_x;
                }
                else if(x_pos>max_x-50){
                    x_pos = max_x-50;
                    delta_x = -delta_x;
                }
        }
        
    }
    
    public float getX(){
        return x_pos;
    }
    
    public float getY(){
        return y_pos;
    }

    public void downHP(){
        --HP;
    }
    
    public boolean isCollidedWithShot(Shot[] shots) {
        for (Shot shot : shots) {
            if (shot == null||shot.isAlive()==false) {
                continue;
            }
            if (-collision_distance_y_shot <= (y_pos - shot.getY()) && (y_pos - shot.getY() <= collision_distance_y_enemy)) {
                if (-collision_distance_x_shot <= (x_pos - shot.getX()) && (x_pos - shot.getX() <= collision_distance_x_enemy)) {
                    //collided.
                    shot.collided();
                    return true;
                }
            }
        }
        return false;
    }
    
    public boolean isCollidedWithPlayer(Player player) {
        if (-collision_distance_y_enemy <= (y_pos - player.getY()) && (y_pos - player.getY() <= collision_distance_y_player)) {
            if (-collision_distance_x_enemy <= (x_pos - player.getX()) && (x_pos - player.getX() <= collision_distance_x_player)) {
                //collided.
                return true;
            }
        }
        return false;
    }
    
    public void draw(Graphics g) {
        File sourceimage = new File("res/character/enemy.png");
        Image img = null;
		try {
			img = ImageIO.read(sourceimage);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
                g.drawImage(img, (int)x_pos, (int)y_pos, 70, 38, null);
    }
    
    public EnemyShot attackShot(){
        EnemyShot enemyShot = new EnemyShot((int)x_pos, (int)y_pos);
        
        return enemyShot;
    }
    
}

