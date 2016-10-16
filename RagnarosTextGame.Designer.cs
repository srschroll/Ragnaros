namespace Ragnaros {
    partial class RagnarosTextGame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bNewGame = new System.Windows.Forms.Button();
            this.bLoadSave = new System.Windows.Forms.Button();
            this.bSignIn = new System.Windows.Forms.Button();
            this.lStartScreen = new System.Windows.Forms.Label();
            this.lGameWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lHitPoints = new System.Windows.Forms.Label();
            this.lLevel = new System.Windows.Forms.Label();
            this.lGold = new System.Windows.Forms.Label();
            this.lExperience = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bNewGame
            // 
            this.bNewGame.Location = new System.Drawing.Point(319, 473);
            this.bNewGame.Name = "bNewGame";
            this.bNewGame.Size = new System.Drawing.Size(119, 34);
            this.bNewGame.TabIndex = 0;
            this.bNewGame.Text = "New Game";
            this.bNewGame.UseVisualStyleBackColor = true;
            this.bNewGame.Click += new System.EventHandler(this.bNewGame_Click);
            // 
            // bLoadSave
            // 
            this.bLoadSave.Location = new System.Drawing.Point(474, 473);
            this.bLoadSave.Name = "bLoadSave";
            this.bLoadSave.Size = new System.Drawing.Size(119, 34);
            this.bLoadSave.TabIndex = 1;
            this.bLoadSave.Text = "Load";
            this.bLoadSave.UseVisualStyleBackColor = true;
            // 
            // bSignIn
            // 
            this.bSignIn.Location = new System.Drawing.Point(627, 473);
            this.bSignIn.Name = "bSignIn";
            this.bSignIn.Size = new System.Drawing.Size(119, 34);
            this.bSignIn.TabIndex = 2;
            this.bSignIn.Text = "Sign In";
            this.bSignIn.UseVisualStyleBackColor = true;
            // 
            // lStartScreen
            // 
            this.lStartScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lStartScreen.Location = new System.Drawing.Point(190, 96);
            this.lStartScreen.Name = "lStartScreen";
            this.lStartScreen.Size = new System.Drawing.Size(685, 346);
            this.lStartScreen.TabIndex = 3;
            this.lStartScreen.Text = "Welcome to Ragnaros!\r\n\r\n*Click \'New Game\' to start your adventure.\r\n\r\n*Click \'Loa" +
    "d\' to continue from a previous save point.\r\n\r\n*Click \'Sign In\' to auto-load your" +
    " progress when you start the game!";
            this.lStartScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lGameWindow
            // 
            this.lGameWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lGameWindow.Location = new System.Drawing.Point(190, 96);
            this.lGameWindow.Name = "lGameWindow";
            this.lGameWindow.Size = new System.Drawing.Size(685, 346);
            this.lGameWindow.TabIndex = 4;
            this.lGameWindow.Text = "Game Text Here - Story / Options / Travel / Inventory / etc";
            this.lGameWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hit Points:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Experience:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(87, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gold:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(84, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Level:";
            this.label4.Visible = false;
            // 
            // lHitPoints
            // 
            this.lHitPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lHitPoints.Location = new System.Drawing.Point(147, 96);
            this.lHitPoints.Name = "lHitPoints";
            this.lHitPoints.Size = new System.Drawing.Size(37, 22);
            this.lHitPoints.TabIndex = 9;
            this.lHitPoints.Visible = false;
            // 
            // lLevel
            // 
            this.lLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lLevel.Location = new System.Drawing.Point(147, 219);
            this.lLevel.Name = "lLevel";
            this.lLevel.Size = new System.Drawing.Size(37, 22);
            this.lLevel.TabIndex = 11;
            this.lLevel.Visible = false;
            // 
            // lGold
            // 
            this.lGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lGold.Location = new System.Drawing.Point(147, 178);
            this.lGold.Name = "lGold";
            this.lGold.Size = new System.Drawing.Size(37, 22);
            this.lGold.TabIndex = 12;
            this.lGold.Visible = false;
            // 
            // lExperience
            // 
            this.lExperience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lExperience.Location = new System.Drawing.Point(147, 137);
            this.lExperience.Name = "lExperience";
            this.lExperience.Size = new System.Drawing.Size(37, 22);
            this.lExperience.TabIndex = 13;
            this.lExperience.Visible = false;
            // 
            // RagnarosTextGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 636);
            this.Controls.Add(this.lExperience);
            this.Controls.Add(this.lGold);
            this.Controls.Add(this.lLevel);
            this.Controls.Add(this.lHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lStartScreen);
            this.Controls.Add(this.bSignIn);
            this.Controls.Add(this.bLoadSave);
            this.Controls.Add(this.bNewGame);
            this.Controls.Add(this.lGameWindow);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RagnarosTextGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAGNAROS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNewGame;
        private System.Windows.Forms.Button bLoadSave;
        private System.Windows.Forms.Button bSignIn;
        private System.Windows.Forms.Label lStartScreen;
        private System.Windows.Forms.Label lGameWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lHitPoints;
        private System.Windows.Forms.Label lLevel;
        private System.Windows.Forms.Label lGold;
        private System.Windows.Forms.Label lExperience;
    }
}