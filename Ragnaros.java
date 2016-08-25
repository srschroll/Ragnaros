/*
 * Ragnaros (c)
 * Developed by Shane R Schroll
 * August 25, 2016
 * Dependent Files(
 * RagnarosChar Class
*/

import javax.swing.*;
import java.awt.Canvas;
import java.awt.Dimension;
import java.awt.BorderLayout;

public class Ragnaros 
{
	public static void main(String[] args) 
	{
		// Create game window
		final JFrame gameWindow = new JFrame("Ragnaros");
		gameWindow.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		RagnarosChar mainChar = new RagnarosChar();

		gameWindow.pack(); // auto size to components
		gameWindow.setVisible(true);
		// end of frame constructor
		
		System.exit(0);
	}
}