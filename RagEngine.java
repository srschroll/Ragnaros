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

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class RagEngine extends JFrame
{
	private boolean isRunning; // for update()
	
	/* Entry point */
	public static void main(String[] args) {
		
	}
	
	
	/* This method starts the game and loops it */
	public void run() {
		init();
	}
	
	
	/* This method sets up things needed for the game to run */
	public void init() {
		
	}
	
	/* This method checks for input, win/loss conditions, moves objects around, etc */
	public void update() {	
		 while(isRunning) {	
			// TODO: check conditions and input
		}
	}
	
	
	/* This method draws everything */
	public void draw()
	{
		
	}
}