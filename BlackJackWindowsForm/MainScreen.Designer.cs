namespace BlackJackWindowsForm
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HitButton = new System.Windows.Forms.Button();
            this.StayButton = new System.Windows.Forms.Button();
            this.DoubleButton = new System.Windows.Forms.Button();
            this.BetSlider = new System.Windows.Forms.TrackBar();
            this.CurBetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            this.DealerScoreLabel = new System.Windows.Forms.Label();
            this.LargeDialog = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.DealerCard1 = new System.Windows.Forms.PictureBox();
            this.DealerCard2 = new System.Windows.Forms.PictureBox();
            this.DealerCard3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DealerCard4 = new System.Windows.Forms.PictureBox();
            this.DealerCard5 = new System.Windows.Forms.PictureBox();
            this.DealerCard6 = new System.Windows.Forms.PictureBox();
            this.DealerCard7 = new System.Windows.Forms.PictureBox();
            this.PlayerCard7 = new System.Windows.Forms.PictureBox();
            this.PlayerCard6 = new System.Windows.Forms.PictureBox();
            this.PlayerCard5 = new System.Windows.Forms.PictureBox();
            this.PlayerCard4 = new System.Windows.Forms.PictureBox();
            this.PlayerCard3 = new System.Windows.Forms.PictureBox();
            this.PlayerCard2 = new System.Windows.Forms.PictureBox();
            this.PlayerCard1 = new System.Windows.Forms.PictureBox();
            this.BetComfirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BetSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).BeginInit();
   
            this.SuspendLayout();
            // 
            // HitButton
            // 
            this.HitButton.Location = new System.Drawing.Point(18, 688);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(245, 76);
            this.HitButton.TabIndex = 0;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // StayButton
            // 
            this.StayButton.Location = new System.Drawing.Point(300, 688);
            this.StayButton.Name = "StayButton";
            this.StayButton.Size = new System.Drawing.Size(247, 76);
            this.StayButton.TabIndex = 1;
            this.StayButton.Text = "Stay";
            this.StayButton.UseVisualStyleBackColor = true;
            this.StayButton.Click += new System.EventHandler(this.StayButton_Click);
            // 
            // DoubleButton
            // 
            this.DoubleButton.Location = new System.Drawing.Point(18, 790);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(246, 80);
            this.DoubleButton.TabIndex = 2;
            this.DoubleButton.Text = "Double Down";
            this.DoubleButton.UseVisualStyleBackColor = true;
            this.DoubleButton.Click += new System.EventHandler(this.DoubleButton_Click);

            // 
            // BetSlider
            // 
            this.BetSlider.Location = new System.Drawing.Point(18, 575);
            this.BetSlider.Maximum = 100;
            this.BetSlider.Name = "BetSlider";
            this.BetSlider.Size = new System.Drawing.Size(524, 45);
            this.BetSlider.TabIndex = 5;
            this.BetSlider.TickFrequency = 5;
            this.BetSlider.Value = 5;
            this.BetSlider.ValueChanged += new System.EventHandler(this.BetSlider_ValueChanged);
            // 
            // CurBetLabel
            // 
            this.CurBetLabel.AccessibleName = "CurBetLabel";
            this.CurBetLabel.Font = new System.Drawing.Font("Goudy Stout", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurBetLabel.Location = new System.Drawing.Point(298, 445);
            this.CurBetLabel.Name = "CurBetLabel";
            this.CurBetLabel.Size = new System.Drawing.Size(244, 85);
            this.CurBetLabel.TabIndex = 6;
            this.CurBetLabel.Text = "5 $";
            this.CurBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Bet ";
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerScoreLabel.Font = new System.Drawing.Font("Goudy Stout", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerScoreLabel.Location = new System.Drawing.Point(597, 639);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(133, 63);
            this.PlayerScoreLabel.TabIndex = 8;
            this.PlayerScoreLabel.Text = "0";
            this.PlayerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DealerScoreLabel
            // 
            this.DealerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.DealerScoreLabel.Font = new System.Drawing.Font("Goudy Stout", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DealerScoreLabel.Location = new System.Drawing.Point(597, 104);
            this.DealerScoreLabel.Name = "DealerScoreLabel";
            this.DealerScoreLabel.Size = new System.Drawing.Size(133, 63);
            this.DealerScoreLabel.TabIndex = 9;
            this.DealerScoreLabel.Text = "0";
            this.DealerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LargeDialog
            // 
            this.LargeDialog.BackColor = System.Drawing.Color.White;
            this.LargeDialog.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LargeDialog.Location = new System.Drawing.Point(26, 40);
            this.LargeDialog.Name = "LargeDialog";
            this.LargeDialog.Size = new System.Drawing.Size(502, 244);
            this.LargeDialog.TabIndex = 10;
            this.LargeDialog.Text = "Please Enter Bet Amount";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AccessibleName = "CurBetLabel";
            this.BalanceLabel.Font = new System.Drawing.Font("Goudy Stout", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BalanceLabel.Location = new System.Drawing.Point(20, 310);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(522, 85);
            this.BalanceLabel.TabIndex = 12;
            this.BalanceLabel.Text = "1000 $";
            this.BalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DealerCard1
            // 
            this.DealerCard1.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealerCard1.Location = new System.Drawing.Point(900, 15);
            this.DealerCard1.Name = "DealerCard1";
            this.DealerCard1.Size = new System.Drawing.Size(175, 235);
            this.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard1.TabIndex = 13;
            this.DealerCard1.TabStop = false;
            // 
            // DealerCard2
            // 
            this.DealerCard2.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealerCard2.Location = new System.Drawing.Point(940, 40);
            this.DealerCard2.Name = "DealerCard2";
            this.DealerCard2.Size = new System.Drawing.Size(175, 235);
            this.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard2.TabIndex = 14;
            this.DealerCard2.TabStop = false;
            // 
            // DealerCard3
            // 
            this.DealerCard3.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealerCard3.Location = new System.Drawing.Point(980, 65);
            this.DealerCard3.Name = "DealerCard3";
            this.DealerCard3.Size = new System.Drawing.Size(175, 235);
            this.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard3.TabIndex = 15;
            this.DealerCard3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(1020, 990);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 235);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // DealerCard4
            // 
            this.DealerCard4.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealerCard4.Location = new System.Drawing.Point(1020, 90);
            this.DealerCard4.Name = "DealerCard4";
            this.DealerCard4.Size = new System.Drawing.Size(175, 235);
            this.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard4.TabIndex = 17;
            this.DealerCard4.TabStop = false;
            // 
            // DealerCard5
            // 
            this.DealerCard5.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealerCard5.Location = new System.Drawing.Point(1060, 115);
            this.DealerCard5.Name = "DealerCard5";
            this.DealerCard5.Size = new System.Drawing.Size(175, 235);
            this.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard5.TabIndex = 18;
            this.DealerCard5.TabStop = false;
            // 
            // DealerCard6
            // 
            this.DealerCard6.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealerCard6.Location = new System.Drawing.Point(1100, 140);
            this.DealerCard6.Name = "DealerCard6";
            this.DealerCard6.Size = new System.Drawing.Size(175, 235);
            this.DealerCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard6.TabIndex = 19;
            this.DealerCard6.TabStop = false;
            // 
            // DealerCard7
            // 
            this.DealerCard7.BackColor = System.Drawing.Color.Transparent;
            this.DealerCard7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealerCard7.Location = new System.Drawing.Point(1140, 165);
            this.DealerCard7.Name = "DealerCard7";
            this.DealerCard7.Size = new System.Drawing.Size(175, 235);
            this.DealerCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerCard7.TabIndex = 20;
            this.DealerCard7.TabStop = false;
            // 
            // PlayerCard7
            // 
            this.PlayerCard7.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerCard7.Location = new System.Drawing.Point(1140, 641);
            this.PlayerCard7.Name = "PlayerCard7";
            this.PlayerCard7.Size = new System.Drawing.Size(175, 235);
            this.PlayerCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard7.TabIndex = 27;
            this.PlayerCard7.TabStop = false;
            // 
            // PlayerCard6
            // 
            this.PlayerCard6.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerCard6.Location = new System.Drawing.Point(1100, 616);
            this.PlayerCard6.Name = "PlayerCard6";
            this.PlayerCard6.Size = new System.Drawing.Size(175, 235);
            this.PlayerCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard6.TabIndex = 26;
            this.PlayerCard6.TabStop = false;
            // 
            // PlayerCard5
            // 
            this.PlayerCard5.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerCard5.Location = new System.Drawing.Point(1060, 591);
            this.PlayerCard5.Name = "PlayerCard5";
            this.PlayerCard5.Size = new System.Drawing.Size(175, 235);
            this.PlayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard5.TabIndex = 25;
            this.PlayerCard5.TabStop = false;
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerCard4.Location = new System.Drawing.Point(1020, 566);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Size = new System.Drawing.Size(175, 235);
            this.PlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard4.TabIndex = 24;
            this.PlayerCard4.TabStop = false;
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerCard3.Location = new System.Drawing.Point(980, 541);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Size = new System.Drawing.Size(175, 235);
            this.PlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard3.TabIndex = 23;
            this.PlayerCard3.TabStop = false;
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerCard2.Location = new System.Drawing.Point(940, 516);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(175, 235);
            this.PlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard2.TabIndex = 22;
            this.PlayerCard2.TabStop = false;
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.BackColor = System.Drawing.Color.Transparent;
            this.PlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerCard1.Location = new System.Drawing.Point(900, 491);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(175, 235);
            this.PlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard1.TabIndex = 21;
            this.PlayerCard1.TabStop = false;
            // 
            // BetComfirmButton
            // 
            this.BetComfirmButton.Location = new System.Drawing.Point(26, 626);
            this.BetComfirmButton.Name = "BetComfirmButton";
            this.BetComfirmButton.Size = new System.Drawing.Size(506, 26);
            this.BetComfirmButton.TabIndex = 28;
            this.BetComfirmButton.Text = "Comfirm Bet / Start Hand";
            this.BetComfirmButton.UseVisualStyleBackColor = true;
            this.BetComfirmButton.Click += new System.EventHandler(this.BetComfirmButton_Click);

            // 
            // MainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::BlackJackWindowsForm.Properties.Resources.Green_Green_PO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1855, 891);
            this.Controls.Add(this.BetComfirmButton);
            this.Controls.Add(this.PlayerCard7);
            this.Controls.Add(this.PlayerCard6);
            this.Controls.Add(this.PlayerCard5);
            this.Controls.Add(this.PlayerCard4);
            this.Controls.Add(this.PlayerCard3);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.DealerCard7);
            this.Controls.Add(this.DealerCard6);
            this.Controls.Add(this.DealerCard5);
            this.Controls.Add(this.DealerCard4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.DealerCard3);
            this.Controls.Add(this.DealerCard2);
            this.Controls.Add(this.DealerCard1);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.LargeDialog);
            this.Controls.Add(this.DealerScoreLabel);
            this.Controls.Add(this.PlayerScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurBetLabel);
            this.Controls.Add(this.BetSlider);
            this.Controls.Add(this.DoubleButton);
            this.Controls.Add(this.StayButton);
            this.Controls.Add(this.HitButton);
 
            this.DoubleBuffered = true;
            this.Name = "MainScreen";
            this.RightToLeftLayout = true;
            this.Text = "BlackJack App";
            ((System.ComponentModel.ISupportInitialize)(this.BetSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button HitButton;
        private Button StayButton;
        private Button DoubleButton;
        private TrackBar BetSlider;
        private Label CurBetLabel;
        private Label label1;
        private Label PlayerScoreLabel;
        private Label DealerScoreLabel;
        private Label LargeDialog;
        private Label BalanceLabel;
        private PictureBox DealerCard1;
        private PictureBox DealerCard2;
        private PictureBox DealerCard3;
        private PictureBox pictureBox4;
        private PictureBox DealerCard4;
        private PictureBox DealerCard5;
        private PictureBox DealerCard6;
        private PictureBox DealerCard7;
        private PictureBox PlayerCard7;
        private PictureBox PlayerCard6;
        private PictureBox PlayerCard5;
        private PictureBox PlayerCard4;
        private PictureBox PlayerCard3;
        private PictureBox PlayerCard2;
        private PictureBox PlayerCard1;
        private Button BetComfirmButton;

    }
}