/* 
 * Ragnaros (c) 2016
 * Developed, Designed and produced by Shane R Schroll
 * Last Update: August 25, 2016
 * 
 * 
 * Ragnaros Game Engine  RagEngine_Version 1
 * Built for 2D, top-down development
 * Designed by Shane R Schroll
*/

import javax.swing.JFrame;
import java.awt.*;
import java.awt.event.KeyEvent;
import java.awt.image.BufferedImage;

public class RagEngine extends JFrame
{
	private static final long serialVersionUID = 1L;
	
	boolean isRunning = true;
	int fps = 30; // Prevent game from running too fast [cap @ 30fps]
	int wWidth = 720;
	int wHeight = 480;
	int x; // For horizontal movement
	int y; // For vertical movement
	
	BufferedImage backBuffer;
	InputHandler input;
	
	/* Entry point */
	public static void main(String[] args) {
		Ragnaros ragnaros = new Ragnaros();
		ragnaros.run();
		System.exit(0);
	}
	
	
	/* This method starts the game and loops it */
	public void run() {
		init();
		
		while(isRunning) 
		{
			long time = System.currentTimeMillis();
			
			update();
			draw();
			
			// Frame delay
			time = (1000 / fps) - (System.currentTimeMillis() - time);
			
			// Have the frame 'pause' temporarily (speed control)
			if(time > 0) 
			{
				try { Thread.sleep(time); }
				catch(Exception e) {}
			}
		}
		
		setVisible(false);
	}
	
	
	/* This method sets up things needed for the game to run */
	void init() {
		setTitle("Ragnaros");
		setSize(wWidth, wHeight);
		setResizable(false); // Fixed window size *Stretch to fit - possible update later
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setVisible(true);
		
		backBuffer = new BufferedImage(wWidth, wHeight, BufferedImage.TYPE_INT_RGB);
		input = new InputHandler();
	}
	
	
	/* This method checks for input, win/loss conditions, moves objects, etc */
	void update() {
		if(input.isKeyDown(KeyEvent.VK_RIGHT))
		{
			x += 6;
		}
		
		if (input.isKeyDown(KeyEvent.VK_LEFT))
		{
			x -= 6;
		}

	}
	
	
	/* This method draws everything */
	void draw() {
		
	}
}