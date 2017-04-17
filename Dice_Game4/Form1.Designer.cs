namespace Dice_Game4
{
    partial class Form1_load
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_load));
            this.but_roll_dice = new System.Windows.Forms.Button();
            this.lab_guess = new System.Windows.Forms.Label();
            this.lab_guess_text = new System.Windows.Forms.Label();
            this.lab_dice1 = new System.Windows.Forms.Label();
            this.lab_dice4 = new System.Windows.Forms.Label();
            this.lab_dice3 = new System.Windows.Forms.Label();
            this.lab_dice2 = new System.Windows.Forms.Label();
            this.betamt_4 = new System.Windows.Forms.TextBox();
            this.betamt_0 = new System.Windows.Forms.TextBox();
            this.betamt_3 = new System.Windows.Forms.TextBox();
            this.betamt_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_bet4 = new System.Windows.Forms.RadioButton();
            this.lab_bet3 = new System.Windows.Forms.RadioButton();
            this.lab_bet2 = new System.Windows.Forms.RadioButton();
            this.lab_bet0 = new System.Windows.Forms.RadioButton();
            this.display_bet_result = new System.Windows.Forms.Label();
            this.winamt_display = new System.Windows.Forms.Label();
            this.displayResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.account_balance = new System.Windows.Forms.Label();
            this.TopUp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_roll_dice
            // 
            this.but_roll_dice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("but_roll_dice.BackgroundImage")));
            this.but_roll_dice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_roll_dice.ForeColor = System.Drawing.Color.White;
            this.but_roll_dice.Location = new System.Drawing.Point(79, 482);
            this.but_roll_dice.Name = "but_roll_dice";
            this.but_roll_dice.Size = new System.Drawing.Size(123, 51);
            this.but_roll_dice.TabIndex = 1;
            this.but_roll_dice.Text = "Roll Dice";
            this.but_roll_dice.UseVisualStyleBackColor = true;
            this.but_roll_dice.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_guess
            // 
            this.lab_guess.BackColor = System.Drawing.Color.Green;
            this.lab_guess.Image = ((System.Drawing.Image)(resources.GetObject("lab_guess.Image")));
            this.lab_guess.Location = new System.Drawing.Point(165, 36);
            this.lab_guess.Name = "lab_guess";
            this.lab_guess.Size = new System.Drawing.Size(577, 243);
            this.lab_guess.TabIndex = 7;
            this.lab_guess.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lab_guess_text
            // 
            this.lab_guess_text.BackColor = System.Drawing.Color.Green;
            this.lab_guess_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_guess_text.ForeColor = System.Drawing.Color.Red;
            this.lab_guess_text.Location = new System.Drawing.Point(623, 296);
            this.lab_guess_text.Name = "lab_guess_text";
            this.lab_guess_text.Size = new System.Drawing.Size(293, 41);
            this.lab_guess_text.TabIndex = 13;
            this.lab_guess_text.Text = "CHOOSE YOUR BETTING HERE..";
            // 
            // lab_dice1
            // 
            this.lab_dice1.Image = global::Dice_Game4.Properties.Resources.dice_blank;
            this.lab_dice1.Location = new System.Drawing.Point(68, 398);
            this.lab_dice1.Name = "lab_dice1";
            this.lab_dice1.Size = new System.Drawing.Size(50, 50);
            this.lab_dice1.TabIndex = 14;
            this.lab_dice1.Click += new System.EventHandler(this.lab_dice1_Click);
            // 
            // lab_dice4
            // 
            this.lab_dice4.Image = global::Dice_Game4.Properties.Resources.dice_blank;
            this.lab_dice4.Location = new System.Drawing.Point(236, 398);
            this.lab_dice4.Name = "lab_dice4";
            this.lab_dice4.Size = new System.Drawing.Size(50, 50);
            this.lab_dice4.TabIndex = 16;
            // 
            // lab_dice3
            // 
            this.lab_dice3.Image = global::Dice_Game4.Properties.Resources.dice_blank;
            this.lab_dice3.Location = new System.Drawing.Point(180, 398);
            this.lab_dice3.Name = "lab_dice3";
            this.lab_dice3.Size = new System.Drawing.Size(50, 50);
            this.lab_dice3.TabIndex = 17;
            // 
            // lab_dice2
            // 
            this.lab_dice2.Image = global::Dice_Game4.Properties.Resources.dice_blank;
            this.lab_dice2.Location = new System.Drawing.Point(124, 398);
            this.lab_dice2.Name = "lab_dice2";
            this.lab_dice2.Size = new System.Drawing.Size(50, 50);
            this.lab_dice2.TabIndex = 18;
            // 
            // betamt_4
            // 
            this.betamt_4.BackColor = System.Drawing.Color.White;
            this.betamt_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betamt_4.Location = new System.Drawing.Point(778, 391);
            this.betamt_4.Name = "betamt_4";
            this.betamt_4.Size = new System.Drawing.Size(149, 24);
            this.betamt_4.TabIndex = 24;
            this.betamt_4.TextChanged += new System.EventHandler(this.betamt_1_TextChanged);
            // 
            // betamt_0
            // 
            this.betamt_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betamt_0.Location = new System.Drawing.Point(778, 533);
            this.betamt_0.Name = "betamt_0";
            this.betamt_0.Size = new System.Drawing.Size(149, 24);
            this.betamt_0.TabIndex = 26;
            this.betamt_0.TextChanged += new System.EventHandler(this.betamt_0_TextChanged);
            // 
            // betamt_3
            // 
            this.betamt_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betamt_3.Location = new System.Drawing.Point(778, 433);
            this.betamt_3.Name = "betamt_3";
            this.betamt_3.Size = new System.Drawing.Size(149, 24);
            this.betamt_3.TabIndex = 27;
            this.betamt_3.TextChanged += new System.EventHandler(this.betamt_2_TextChanged);
            // 
            // betamt_2
            // 
            this.betamt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betamt_2.Location = new System.Drawing.Point(778, 482);
            this.betamt_2.Name = "betamt_2";
            this.betamt_2.Size = new System.Drawing.Size(149, 24);
            this.betamt_2.TabIndex = 28;
            this.betamt_2.TextChanged += new System.EventHandler(this.betamt_3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(772, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = " Betting Amount: EUR";
            // 
            // lab_bet4
            // 
            this.lab_bet4.AutoSize = true;
            this.lab_bet4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bet4.Location = new System.Drawing.Point(612, 391);
            this.lab_bet4.Name = "lab_bet4";
            this.lab_bet4.Size = new System.Drawing.Size(145, 20);
            this.lab_bet4.TabIndex = 30;
            this.lab_bet4.TabStop = true;
            this.lab_bet4.Text = "Bet for 4 Matches";
            this.lab_bet4.UseVisualStyleBackColor = true;
            this.lab_bet4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lab_bet3
            // 
            this.lab_bet3.AutoSize = true;
            this.lab_bet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bet3.Location = new System.Drawing.Point(612, 437);
            this.lab_bet3.Name = "lab_bet3";
            this.lab_bet3.Size = new System.Drawing.Size(145, 20);
            this.lab_bet3.TabIndex = 33;
            this.lab_bet3.TabStop = true;
            this.lab_bet3.Text = "Bet for 3 Matches";
            this.lab_bet3.UseVisualStyleBackColor = true;
            this.lab_bet3.CheckedChanged += new System.EventHandler(this.lab_bet3_CheckedChanged);
            // 
            // lab_bet2
            // 
            this.lab_bet2.AutoSize = true;
            this.lab_bet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bet2.Location = new System.Drawing.Point(612, 482);
            this.lab_bet2.Name = "lab_bet2";
            this.lab_bet2.Size = new System.Drawing.Size(145, 20);
            this.lab_bet2.TabIndex = 34;
            this.lab_bet2.TabStop = true;
            this.lab_bet2.Text = "Bet for 2 Matches";
            this.lab_bet2.UseVisualStyleBackColor = true;
            this.lab_bet2.CheckedChanged += new System.EventHandler(this.lab_bet2_CheckedChanged);
            // 
            // lab_bet0
            // 
            this.lab_bet0.AutoSize = true;
            this.lab_bet0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_bet0.Location = new System.Drawing.Point(612, 533);
            this.lab_bet0.Name = "lab_bet0";
            this.lab_bet0.Size = new System.Drawing.Size(157, 20);
            this.lab_bet0.TabIndex = 36;
            this.lab_bet0.TabStop = true;
            this.lab_bet0.Text = "Bet for No Matches";
            this.lab_bet0.UseVisualStyleBackColor = true;
            this.lab_bet0.CheckedChanged += new System.EventHandler(this.lab_bet0_CheckedChanged);
            // 
            // display_bet_result
            // 
            this.display_bet_result.BackColor = System.Drawing.Color.Green;
            this.display_bet_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_bet_result.ForeColor = System.Drawing.Color.Red;
            this.display_bet_result.Location = new System.Drawing.Point(239, 312);
            this.display_bet_result.Name = "display_bet_result";
            this.display_bet_result.Size = new System.Drawing.Size(179, 58);
            this.display_bet_result.TabIndex = 37;
            this.display_bet_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.display_bet_result.Click += new System.EventHandler(this.display_bet_result_Click);
            // 
            // winamt_display
            // 
            this.winamt_display.BackColor = System.Drawing.Color.Green;
            this.winamt_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winamt_display.Location = new System.Drawing.Point(416, 312);
            this.winamt_display.Name = "winamt_display";
            this.winamt_display.Size = new System.Drawing.Size(145, 58);
            this.winamt_display.TabIndex = 38;
            this.winamt_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayResult
            // 
            this.displayResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.displayResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.displayResult.Location = new System.Drawing.Point(282, 507);
            this.displayResult.Name = "displayResult";
            this.displayResult.Size = new System.Drawing.Size(263, 66);
            this.displayResult.TabIndex = 39;
            this.displayResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.howToPlayToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem1
            // 
            this.howToPlayToolStripMenuItem1.Name = "howToPlayToolStripMenuItem1";
            this.howToPlayToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.howToPlayToolStripMenuItem1.Text = "How to Play";
            this.howToPlayToolStripMenuItem1.Click += new System.EventHandler(this.howToPlayToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(165, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 155);
            this.label2.TabIndex = 41;
            // 
            // account_balance
            // 
            this.account_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_balance.Location = new System.Drawing.Point(796, 111);
            this.account_balance.Name = "account_balance";
            this.account_balance.Size = new System.Drawing.Size(162, 51);
            this.account_balance.TabIndex = 43;
            this.account_balance.Text = "1000";
            this.account_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopUp
            // 
            this.TopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TopUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopUp.BackgroundImage")));
            this.TopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopUp.ForeColor = System.Drawing.Color.Purple;
            this.TopUp.Location = new System.Drawing.Point(826, 191);
            this.TopUp.Name = "TopUp";
            this.TopUp.Size = new System.Drawing.Size(121, 39);
            this.TopUp.TabIndex = 44;
            this.TopUp.Text = "TOPUP Account";
            this.TopUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TopUp.UseVisualStyleBackColor = false;
            this.TopUp.Click += new System.EventHandler(this.TopUp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(748, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Account Balance EUR:";
            // 
            // Form1_load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 642);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TopUp);
            this.Controls.Add(this.account_balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayResult);
            this.Controls.Add(this.winamt_display);
            this.Controls.Add(this.display_bet_result);
            this.Controls.Add(this.lab_bet0);
            this.Controls.Add(this.lab_bet2);
            this.Controls.Add(this.lab_bet3);
            this.Controls.Add(this.lab_bet4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betamt_2);
            this.Controls.Add(this.betamt_3);
            this.Controls.Add(this.betamt_0);
            this.Controls.Add(this.betamt_4);
            this.Controls.Add(this.lab_dice2);
            this.Controls.Add(this.lab_dice3);
            this.Controls.Add(this.lab_dice4);
            this.Controls.Add(this.lab_dice1);
            this.Controls.Add(this.lab_guess_text);
            this.Controls.Add(this.lab_guess);
            this.Controls.Add(this.but_roll_dice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1_load";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_load_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_roll_dice;
        private System.Windows.Forms.Label lab_guess;
        private System.Windows.Forms.Label lab_guess_text;
        private System.Windows.Forms.Label lab_dice1;
        private System.Windows.Forms.Label lab_dice4;
        private System.Windows.Forms.Label lab_dice3;
        private System.Windows.Forms.Label lab_dice2;
        private System.Windows.Forms.TextBox betamt_4;
        private System.Windows.Forms.TextBox betamt_0;
        private System.Windows.Forms.TextBox betamt_3;
        private System.Windows.Forms.TextBox betamt_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton lab_bet4;
        private System.Windows.Forms.RadioButton lab_bet3;
        private System.Windows.Forms.RadioButton lab_bet2;
        private System.Windows.Forms.RadioButton lab_bet0;
        private System.Windows.Forms.Label display_bet_result;
        private System.Windows.Forms.Label winamt_display;
        private System.Windows.Forms.Label displayResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label account_balance;
        private System.Windows.Forms.Button TopUp;
        private System.Windows.Forms.Label label4;
    }
}

