/* Shane Schroll
 * October 13, 2016
 * Ragnaros -> Text-Based Game -> Copyright 2016 -> Shane Schroll
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ragnaros {

    /* Partial classes -> https://msdn.microsoft.com/en-us/library/wa80x488.aspx */
    public partial class RagnarosTextGame : Form {

        public RagnarosTextGame() {
            InitializeComponent();
        }

    public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); // Explicit false
            Application.Run(new RagnarosTextGame()); // Creates a new instance for the game to run
        }

        /*************************/
        /**** Player Controls ****/

        private int RandomDamage(int rd) {
            // TODO: add damage scaling based on player level
            // if(player lvl <= 3) { damage = random number between 1 and 4 [stored in r]}

            return rd;
        }

        private int PlayerHealth(int hp) {

            // TODO: increase health when a player levels up
            // Add an additional function to handle player healing through use of items
            // player lvl goes up to 10
            // HP increase by 10 points per lvl, eg. [1 = 10, 2 = 20, etc]
            // Max Hp = 100 + additional items that increase hp when equipped

            return hp;
        }

        /*****************/
        /**** Buttons ****/

        /* start new game */
        private void bNewGame_Click(object sender, EventArgs e) {
            lStartScreen.Visible = false; // hide the start screen label
            lGameWindow.Visible = true; // show game's starting text window (label)
            bNewGame.Visible = false; // hide new game button
            bLoadSave.Visible = false; // hide load button
            bSignIn.Visible = false; // hide sign in button

            // text values will need to be parsed to int for calculations
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            lHitPoints.Visible = true;
            lHitPoints.Text = "10";
            lExperience.Visible = true;
            lExperience.Text = "0";
            lGold.Visible = true;
            lGold.Text = "150";
            lLevel.Visible = true;
            lLevel.Text = "1";
            // TODO: remove controls from memory instead of hiding them
        }




    }
}