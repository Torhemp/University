package shootinggame;

import java.awt.*;
import java.awt.event.*;
import java.io.File;
import java.io.IOException;
import javax.swing.*;
import java.util.*; 
import javax.imageio.ImageIO;
import javax.sound.sampled.AudioInputStream;
import javax.sound.sampled.AudioSystem;
import javax.sound.sampled.Clip;

public class ShootingGame extends JPanel implements Runnable {
    private Thread thread;
    private Player player;
    private ArrayList boss;
    private ArrayList enemies;
    private ArrayList enemyShots;
    private ArrayList items;
    private Shot[] shots;
    private ArrayList specialEnemies;
    private ArrayList specialEnemyShots;
    private ArrayList bossShots;
    private ArrayList bossShots2;
    private int bossShotSwitch=0;
    private int bossShotAngleGap=15;
    private int bossShotCount=0;
    private int bossShotAngle=0;
    private int bossCheck=0;
    private int specialEnemyCheck=0;
    private int maxShotNum = 200;
    private int playerLevel=1;
    private int playerLife=10;
    private JLabel scoreLabel;
    private int score;
    private int stage=1;
    private final int shotSpeed = 4;
    private final int playerLeftSpeed = -2;
    private final int playerRightSpeed = 2;
    private final int playerUpSpeed = -2;
    private final int playerDownSpeed = 2;
    private final int width = 900;
    private final int height = 400;
    private final int enemyMaxHorizonSpeed = 1;
    private final int enemyMaxVerticalSpeed = 1;
    private final float enemyHorizonSpeedInc = 0.3f;
    private final int enemyMaxMovetype = 5;
    private final int enemyTimeGap = 1500;
    private final int bossTimeGap = 1000;
    private final int bossShotTimeGap = 300;
    private final int playerMargin = 40;
    private final int bossMargin_x = 50;
    private final int bossMargin_y = 100;
    private final int bossMargin2_x = 100;
    private final int bossMargin2_y = 50;
    private final int enemyMargin_x = 60;
    private final int enemyMargin_y = 40;
    private final int specialEnemyMargin_x = 90;
    private final int specialEnemyMargin_y = 60;
    private final int itemTimeGap = 20000;
    private final int itemMaxHorizonSpeed = 1;
    private final int enemyShotTimeGap = 3000;
    private boolean playerMoveLeft;
    private boolean playerMoveRight;
    private boolean playerMoveUp;
    private boolean playerMoveDown;
    private int bx = 0;
    private Random rand;
    private Image dbImage;
    private Graphics dbg;
    private javax.swing.Timer itemTimer;
    private javax.swing.Timer enemyTimer;
    private javax.swing.Timer enemyShotTimer;
    private javax.swing.Timer specialEnemyShotTimer;
    private javax.swing.Timer bossTimer;
    private javax.swing.Timer bossTimer2;
    private javax.swing.Timer bossShotTimer;
    private javax.swing.Timer bossShotTimer2;
    private KeyListener key;
   
    public ShootingGame(){
        setBackground(Color.black);
        setPreferredSize(new Dimension(width, height));
        player = new Player((int) (width * 0.1), height/2, 0, width-playerMargin, 0, height-playerMargin);
        shots = new Shot[ maxShotNum ];
        enemyShots = new ArrayList();
        enemies = new ArrayList();
        items = new ArrayList();
        specialEnemies = new ArrayList();
        specialEnemyShots = new ArrayList();
        boss = new ArrayList();
        bossShots = new ArrayList();
        bossShots2 = new ArrayList();
        rand = new Random(1);
        scoreLabel = new JLabel("SCORE : ");
        enemyTimer = new javax.swing.Timer(enemyTimeGap, new AddNewEnemy());
        enemyTimer.start();
        itemTimer = new javax.swing.Timer(itemTimeGap, new addANewItem());
        itemTimer.start();
        enemyShotTimer = new javax.swing.Timer(enemyShotTimeGap, new shotEnemy());
        enemyShotTimer.start();
        specialEnemyShotTimer = new javax.swing.Timer(enemyShotTimeGap, new shotSpecialEnemy());
        specialEnemyShotTimer.start();
        bossTimer = new javax.swing.Timer(bossTimeGap, new addBoss());
        bossTimer2 = new javax.swing.Timer(bossTimeGap, new addBoss2());
        bossShotTimer = new javax.swing.Timer(bossShotTimeGap, new addBossShot());
        bossShotTimer2 = new javax.swing.Timer(bossShotTimeGap, new addBossShot2());
        addKeyListener(key = new ShipControl());
        setFocusable(true);
    }
    
    public void start(){
        thread = new Thread(this);
        thread.start();
    }
    
    public void drawScore(Graphics g) {
    	g.setColor(Color.WHITE);
    	g.setFont(new Font("굴림", Font.BOLD, 16));
    	g.drawString("Score : "+score, 250, 25);
    }
    
    private class AddNewEnemy implements ActionListener{
        public void actionPerformed(ActionEvent e) {
            float horizonSpeed;
            float verticalSpeed;
            int movetype = (int) rand.nextInt(enemyMaxMovetype);
            do {
                horizonSpeed = rand.nextFloat() * enemyMaxHorizonSpeed;
            } while (horizonSpeed == 0);

            verticalSpeed = rand.nextFloat() * 2 * enemyMaxVerticalSpeed - enemyMaxVerticalSpeed;
            
            if(specialEnemyCheck == 10){
                for(int i=0;i<3;++i){
                    int specialMoveType = (int)rand.nextInt(enemyMaxMovetype);
                    SpecialEnemy newSpecialEnemy = new SpecialEnemy(width-specialEnemyMargin_x/2, (int) (rand.nextFloat() * (height-specialEnemyMargin_y)), horizonSpeed*2, verticalSpeed, width-specialEnemyMargin_x, height-specialEnemyMargin_y, enemyHorizonSpeedInc, specialMoveType);
                    specialEnemies.add(newSpecialEnemy);
                    specialEnemyCheck=0;
                }
            }
            else{
                Enemy newEnemy = new Enemy(width-enemyMargin_x, (int) (rand.nextFloat() * (height-enemyMargin_y)), horizonSpeed*2, verticalSpeed, width-enemyMargin_x, height-enemyMargin_y, enemyHorizonSpeedInc, movetype);
                enemies.add(newEnemy);
                ++specialEnemyCheck;
            }
            if(bossCheck==5)
                switch(stage){
                case 1:
                    bossTimer.start();
                    break;
                case 2:
                    bossTimer2.start();
                    break;
                }
            ++bossCheck;
        }
    }
    
    private class addBoss implements ActionListener{
        public void actionPerformed(ActionEvent e){
            boss.add(new Boss(width-50, (int)(rand.nextFloat()*height-30), (float)1, (float)0.5, width-bossMargin_x, height-bossMargin_y));
            bossShotTimer.start();
            enemyTimer.stop();
            enemyShotTimer.stop();
            specialEnemyShotTimer.stop();
            bossTimer.stop();
        }
    }
    
    private class addBoss2 implements ActionListener{
        public void actionPerformed(ActionEvent e){
            boss.add(new Boss2(width-50, (int)(rand.nextFloat()*height-30), (float)1, (float)0.5, width-bossMargin2_x, height-bossMargin2_y));
            bossShotTimer2.start();
            enemyTimer.stop();
            enemyShotTimer.stop();
            specialEnemyShotTimer.stop();
            bossTimer2.stop();
        }
    }
    
    private class addANewItem implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            float horizonSpeed;
            do {
                horizonSpeed = rand.nextFloat() * itemMaxHorizonSpeed;
            } while (horizonSpeed == 0);

            Item newItem = new Item(width, (int) (rand.nextFloat() * height-50), horizonSpeed);
            items.add(newItem);
        }
    }
    
    private class shotEnemy implements ActionListener{
        public void actionPerformed(ActionEvent e) {
            Iterator enemyList = enemies.iterator();
            while(enemyList.hasNext()){
                Enemy enemy = (Enemy) enemyList.next();
                EnemyShot newEnemyShot = enemy.attackShot();
                enemyShots.add(newEnemyShot);
            }
        }
    }
    
    private class shotSpecialEnemy implements ActionListener{
        public void actionPerformed(ActionEvent e) {
            Iterator specialEnemyList = specialEnemies.iterator();
            while(specialEnemyList.hasNext()){
                SpecialEnemy specialEnemy = (SpecialEnemy) specialEnemyList.next();
                SpecialEnemyShot newSpecialEnemyShot = new SpecialEnemyShot((int) specialEnemy.getX(), (int) specialEnemy.getY());
                specialEnemyShots.add(newSpecialEnemyShot);
            }
        }
    }
    
    private class addBossShot implements ActionListener{
        public void actionPerformed(ActionEvent e){
            Iterator bossList = boss.iterator();
            Boss boss = (Boss)bossList.next();
            switch(bossShotSwitch){
            case 0:
                BossShot newBossShot1 = new BossShot((int)boss.getX(), (int)boss.getY(), bossShotSwitch/2, bossShotAngle, player.getX(), player.getY());
                bossShots.add(newBossShot1);
                bossShotAngle+=bossShotAngleGap;
                ++bossShotCount;
                if(bossShotAngle>=360)
                    bossShotAngle=0;
                if(bossShotCount>=30){
                    ++bossShotSwitch;
                    bossShotCount=0;
                }
                break;
            case 1:
                ++bossShotSwitch;
                break;
            case 2:
                BossShot newBossShot2 = new BossShot((int)boss.getX(), (int)boss.getY(), bossShotSwitch/2, bossShotAngle, player.getX(), player.getY());
                bossShots.add(newBossShot2);
                ++bossShotCount;
                if(bossShotCount>=30){
                    ++bossShotSwitch;
                    bossShotCount=0;
                }
                break;
            case 3:
                ++bossShotSwitch;
                break;
            case 4:
                BossShot newBossShot3 = new BossShot((int)boss.getX(), (int)boss.getY(), bossShotSwitch/2, bossShotAngle, player.getX(), player.getY());
                bossShots.add(newBossShot3);
                ++bossShotCount;
                if(bossShotCount>=30){
                    ++bossShotSwitch;
                    bossShotCount=0;
                }
                break;
            default:
                bossShotSwitch=0;
            }
        }
    }
    
    private class addBossShot2 implements ActionListener{
        public void actionPerformed(ActionEvent e){
            Iterator bossList = boss.iterator();
            Boss boss = (Boss)bossList.next();
            switch(bossShotSwitch){
            case 0:
                BossShot2 newBossShot1 = new BossShot2((int)boss.getX(), (int)boss.getY(), bossShotSwitch/2, bossShotAngle, player.getX(), player.getY(), true);
                bossShots2.add(newBossShot1);
                ++bossShotCount;
                if(bossShotCount>=40){
                    ++bossShotSwitch;
                    bossShotCount=0;
                }
                break;
            case 1:
                ++bossShotSwitch;
                break;
            case 2:
                BossShot2 newBossShot2;
                if(rand.nextBoolean()){
                    newBossShot2 = new BossShot2(rand.nextInt(800), rand.nextInt(50), bossShotSwitch/2, bossShotAngle, player.getX(), player.getY(), true);
                    bossShots2.add(newBossShot2);
                }
                else{
                    newBossShot2 = new BossShot2(rand.nextInt(800), 700-rand.nextInt(50), bossShotSwitch/2, bossShotAngle, player.getX(), player.getY(), false);
                    bossShots2.add(newBossShot2);
                }
                ++bossShotCount;
                if(bossShotCount>=60){
                    ++bossShotSwitch;
                    bossShotCount=0;
                }
                break;
            case 3:
                ++bossShotSwitch;
                break;
            case 4:
                BossShot2 newBossShot3 = new BossShot2((int)boss.getX(), (int)boss.getY(), bossShotSwitch/2, bossShotAngle, player.getX(), player.getY(), true);
                bossShots2.add(newBossShot3);
                ++bossShotCount;
                if(bossShotCount>=30){
                    ++bossShotSwitch;
                    bossShotCount=0;
                }
                break;
            default:
                bossShotSwitch=0;
            }
        }
    }
    
    private class ShipControl implements KeyListener {
        public void keyPressed(KeyEvent e) {
            switch (e.getKeyCode()) {
                case KeyEvent.VK_LEFT:
                    playerMoveLeft = true;
                    break;
                case KeyEvent.VK_RIGHT:
                    playerMoveRight = true;
                    break;
                case KeyEvent.VK_SPACE :
                    for (int i = 0; i < shots.length; i=i+5) {
                        if (shots[i] == null) {
                        	for(int j=0; j < playerLevel; j++) {
                                shots[i+j] = player.generateShot(playerLevel-(j*10));
                                Sound("res/sound/shot1.wav",false, false);
                        	}
                            break;
                        }
                    }
                    break;
                case KeyEvent.VK_UP:
                	playerMoveUp = true;
                    break;
                case KeyEvent.VK_DOWN:
                	playerMoveDown = true;
                    break;
                    
            }
        }

        public void keyReleased(KeyEvent e) {
            switch (e.getKeyCode()) {
                case KeyEvent.VK_LEFT:
                    playerMoveLeft = false;
                    break;
                case KeyEvent.VK_RIGHT:
                    playerMoveRight = false;
                    break;
                case KeyEvent.VK_UP:
                    playerMoveUp = false;
                    break;
                case KeyEvent.VK_DOWN:
                    playerMoveDown = false;
                    break;
            }
        }

        public void keyTyped(KeyEvent e) {
        }
    }
        
    public void run() {
        //int c=0;
        Thread.currentThread().setPriority(Thread.MIN_PRIORITY);
        Sound("res/sound/bgm1.wav",true,false);
        while (true) {
            for (int i = 0; i < shots.length; i++) {
                if (shots[i] != null) {
                    shots[i].moveShot(shotSpeed);
                    if (shots[i].getX()>width) {
                        shots[i] = null;
                    }
                }
            }
            
            if (playerMoveLeft) {
                player.moveX(playerLeftSpeed*2);
            } else if (playerMoveRight) {
                player.moveX(playerRightSpeed*2);
            } else if (playerMoveUp) {
                player.moveY(playerUpSpeed*2);
            } else if (playerMoveDown) {
                player.moveY(playerDownSpeed*2);
            }
            try{
            Iterator enemyList = enemies.iterator();
            Iterator specialEnemyList = specialEnemies.iterator();
            Iterator enemyShotList = enemyShots.iterator();
            Iterator specialEnemyShotList = specialEnemyShots.iterator();
            Iterator bossList = boss.iterator();
            Iterator bossShotList = bossShots.iterator();
            Iterator bossShotList2 = bossShots2.iterator();
            Iterator itemList = items.iterator();
            while(enemyList.hasNext()) {
                Enemy enemy = (Enemy) enemyList.next();
                enemy.move();
            }
            while(enemyShotList.hasNext()){
                EnemyShot enemyShot = (EnemyShot) enemyShotList.next();
                enemyShot.moveShot(3);
            }
            while(specialEnemyList.hasNext()) {
                SpecialEnemy specialEnemy = (SpecialEnemy) specialEnemyList.next();
                specialEnemy.move();
            }
            while(specialEnemyShotList.hasNext()){
                SpecialEnemyShot specialEnemyShot = (SpecialEnemyShot) specialEnemyShotList.next();
                specialEnemyShot.moveShot(2);
            }
            while(bossList.hasNext()) {
                Boss boss = (Boss) bossList.next();
                boss.move();
            }
            while(bossShotList.hasNext()){
                BossShot bossShot = (BossShot) bossShotList.next();
                bossShot.moveShot();
            }
            while(bossShotList2.hasNext()){
                BossShot2 bossShot = (BossShot2) bossShotList2.next();
                bossShot.moveShot();
            }
            while (itemList.hasNext()) {
                Item item = (Item) itemList.next();
                item.move();
            }
            repaint();
            }catch(ConcurrentModificationException cmex){}
            try {
                Thread.sleep(10);
            } catch (Exception ex) {
                // do nothing
            }

            Thread.currentThread().setPriority(Thread.MAX_PRIORITY);
        }
    }
    
    public void initImage(Graphics g) {
        if (dbImage == null) {
            dbImage = createImage(this.getSize().width, this.getSize().height);
            dbg = dbImage.getGraphics();
        }
        Toolkit tk = Toolkit.getDefaultToolkit();
        Image dbImage = tk.getImage("res/background/background.jpg");
        if(bx > -4000){
            dbg.clearRect(0,0,width,height);
            g.drawImage(dbImage,bx,0,5292,900, this);
            bx -= 3;
        }
        else{ 
            bx = -150 ;
            dbg.clearRect(0,0,width,height);
            g.drawImage(dbImage,bx,0,5292,900, this);
        }
    }

    public void paintComponent(Graphics g) {
        initImage(g);
        
        try{
        Iterator enemyList = enemies.iterator();
        while (enemyList.hasNext()) {
            Enemy enemy = (Enemy) enemyList.next();
            enemy.draw(g);
            
            if (enemy.isCollidedWithShot(shots)) {
                enemy.downHP();
                if(enemy.HP<=0){
                    enemyList.remove();
                    score+=500;
                }
            }
            
            if (enemy.isCollidedWithPlayer(player)) {
                enemyList.remove();
                playerLife--;
                if(playerLife<=0){
                    gameOver(g);
                    //System.exit(0);
                }
                	
                playerLevel=1;
            }
        }
        Iterator specialEnemyList = specialEnemies.iterator();
        while (specialEnemyList.hasNext()) {
            SpecialEnemy specialEnemy = (SpecialEnemy) specialEnemyList.next();
            specialEnemy.draw(g);
            
            if (specialEnemy.isCollidedWithShot(shots)) {
                specialEnemy.downHP();
                if(specialEnemy.HP<=0){
                    specialEnemyList.remove();
                    score+=1000;
                }
            }
            
            if (specialEnemy.isCollidedWithPlayer(player)) {
                specialEnemyList.remove();
                playerLife--;
                if(playerLife<=0)
                    gameOver(g);
                	//System.exit(0);
                playerLevel=1;
            }
        }
        Iterator enemyShotList = enemyShots.iterator();
        while(enemyShotList.hasNext()){
            EnemyShot enemyShot = (EnemyShot) enemyShotList.next();
            enemyShot.drawShot(g);
            if(enemyShot.isCollidedWithPlayer(player)){
                enemyShotList.remove();
                playerLife--;
                if(playerLife<=0)
                    gameOver(g);
                	//System.exit(0);
                playerLevel=1;
            }
            if(enemyShot.isAlive()==false)
                enemyShotList.remove();
        }
        Iterator specialEnemyShotList = specialEnemyShots.iterator();
        while(specialEnemyShotList.hasNext()){
            SpecialEnemyShot specialEnemyShot = (SpecialEnemyShot) specialEnemyShotList.next();
            specialEnemyShot.drawShot(g);
            specialEnemyShot.checkAlive();
            if(specialEnemyShot.isCollidedWithPlayer(player)){
                playerLife--;
                if(playerLife<=0)
                    gameOver(g);
                	//System.exit(0);
                playerLevel=1;
            }
            if(specialEnemyShot.isAlive()==false)
                specialEnemyShotList.remove();
        }
        Iterator bossList = boss.iterator();
        while (bossList.hasNext()) {
            Boss boss = (Boss)bossList.next();
            boss.draw(g);
            if (boss.isCollidedWithShot(shots)) {
                boss.downHP();
                if(boss.HP<=0){
                    score+=10000;
                    switch(stage){
                        case 1:
                            bossShotTimer.stop();  
                            bossList.remove();
                            break;
                        case 2:
                            bossShotTimer2.stop();
                            bossList.remove();
                            break;
                    }
                    enemyTimer.start();
                    enemyShotTimer.start();
                    specialEnemyShotTimer.start();
                    ++stage;
                    bossShotSwitch=0;
                    bossCheck=0;
                }
            }
            if (boss.isCollidedWithPlayer(player)) {
                --playerLife;
                if(playerLife<=0)
                    gameOver(g);
                	//System.exit(0);
                playerLevel=1;
            }
        }
        Iterator bossShotList = bossShots.iterator();
        while(bossShotList.hasNext()){
            BossShot bossShot = (BossShot) bossShotList.next();
            bossShot.drawShot(g);
            if(bossShot.isCollidedWithPlayer(player)){
                bossShotList.remove();
                playerLife--;
                if(playerLife<=0)
                    gameOver(g);
                	//System.exit(0);
                playerLevel=1;
            }
            else if(bossShot.isAlive()==false)
                bossShotList.remove();
        }
        Iterator bossShotList2 = bossShots2.iterator();
        while(bossShotList2.hasNext()){
            BossShot2 bossShot = (BossShot2) bossShotList2.next();
            bossShot.drawShot(g);
            if(bossShot.isCollidedWithPlayer(player)){
                bossShotList2.remove();
                playerLife--;
                if(playerLife<=0)
                    gameOver(g);
                	//System.exit(0);
                playerLevel=1;
            }
            else if(bossShot.isAlive()==false)
                bossShotList2.remove();
        }
        Iterator itemList = items.iterator();
        while (itemList.hasNext()) {
            Item item = (Item) itemList.next();
            item.draw(g);
            
            if (item.isCollidedWithPlayer(player)) {
            	if(playerLevel < 5)
            		playerLevel++;
            		itemList.remove();
            }
            if(item.getX()<0)
                itemList.remove();
        }
        }catch(Exception ex){
        }
        for (int i = 0; i < shots.length; i++) {
            if (shots[i] != null) {
                shots[i].drawShot(g);
            }
        }
        drawScore(g);
        player.drawPlayer(g);
        drawLife(g);
    }
    
    private void gameOver(Graphics g){
        enemyTimer.stop();
        itemTimer.stop();
        enemyShotTimer.stop();
        specialEnemyShotTimer.stop();
        bossShotTimer.stop();
        bossTimer.stop();
        int i=0;
        removeKeyListener(key);
        do{
        g.setColor(Color.WHITE);
        g.setFont(new Font("굴림", Font.BOLD, 30));
        g.drawString("GAME OVER", 350, 150);
        g.setFont(new Font("굴림", Font.BOLD, 15));
        g.drawString("Press Z Key, Exit Game", 355, 250);
        i++;
        }while(i<5);
        thread.stop();
        addKeyListener(new over());
    }
    
    private class over implements KeyListener{
        public void keyPressed(KeyEvent e) {
            if(e.getKeyCode()==KeyEvent.VK_Z)
                System.exit(0);
        }

        public void keyReleased(KeyEvent e) {
        }

        public void keyTyped(KeyEvent e) {
        }
    }
    
    private void drawLife(Graphics g) {
    	File sourceimage = new File("res/character/life.png");;
        Image img = null;
		try {
			img = ImageIO.read(sourceimage);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
        
        for(int a=0;a<playerLife;a++)
        {
        	g.drawImage(img, 5+30*a, 5, 30, 30, null);
        }
    }
    
    public void Sound(String fileName, boolean Loop, boolean Stop)
    {
        try
        {
            AudioInputStream ais = AudioSystem.getAudioInputStream(new File(fileName));
            Clip clip = AudioSystem.getClip();
            clip.open(ais);
            clip.start();
            if ( Loop) clip.loop(-1);
            if(Stop){
                clip.stop();
                ais.close();
            }
        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
    }
    
    public static void main(String[] args) {  
        JFrame frame = new JFrame("Space Trip");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        ShootingGame ship = new ShootingGame();
        frame.getContentPane().add(ship);
        frame.pack();
        frame.setVisible(true);
        ship.start();
    }
}
