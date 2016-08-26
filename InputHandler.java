/* 
 * Ragnaros (c) 2016
 * Developed, Designed and produced by Shane R Schroll
 * Last Update: August 25, 2016
 * 
 * 
 * Ragnaros Game InputHandler
 * Built for 2D, top-down development
 * Designed by Shane R Schroll
*/

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class InputHandler implements KeyListener {
	
	public boolean keys[] = new boolean[65536];
	
	public void keyPressed(KeyEvent e) {
		int keycode = e.getKeyCode();
		keys[keycode] = true;
	}
	
	public void keyReleased(KeyEvent e) {
		int keycode = e.getKeyCode();
		keys[keycode] = false;
	}
	
	public void keyTyped(KeyEvent e) {}

	public boolean isKeyDown(int vkRight) {
		return false;
	}
}