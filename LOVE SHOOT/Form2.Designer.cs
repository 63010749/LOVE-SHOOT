namespace LOVE_SHOOT
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Name5 = new System.Windows.Forms.Label();
            this.Name4 = new System.Windows.Forms.Label();
            this.Name3 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.Score5 = new System.Windows.Forms.Label();
            this.Score4 = new System.Windows.Forms.Label();
            this.Score3 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(546, 30);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(355, 29);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.BackColor = System.Drawing.Color.Transparent;
            this.txtAmmo.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(78, 33);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(33, 20);
            this.txtAmmo.TabIndex = 5;
            this.txtAmmo.Text = "10";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(202, 33);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(21, 20);
            this.txtScore.TabIndex = 6;
            this.txtScore.Text = "0";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::LOVE_SHOOT.Properties.Resources.up1;
            this.player.Location = new System.Drawing.Point(426, 521);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::LOVE_SHOOT.Properties.Resources.B_Face1;
            this.pictureBox3.Location = new System.Drawing.Point(485, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LOVE_SHOOT.Properties.Resources.G_Face;
            this.pictureBox2.Location = new System.Drawing.Point(146, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LOVE_SHOOT.Properties.Resources.Ammo_Image1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(335, 30);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(367, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 107);
            this.panel1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Name5);
            this.panel2.Controls.Add(this.Name4);
            this.panel2.Controls.Add(this.Name3);
            this.panel2.Controls.Add(this.Name2);
            this.panel2.Controls.Add(this.Name1);
            this.panel2.Controls.Add(this.Score5);
            this.panel2.Controls.Add(this.Score4);
            this.panel2.Controls.Add(this.Score3);
            this.panel2.Controls.Add(this.Score2);
            this.panel2.Controls.Add(this.Score1);
            this.panel2.Location = new System.Drawing.Point(82, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 269);
            this.panel2.TabIndex = 11;
            // 
            // Name5
            // 
            this.Name5.AutoSize = true;
            this.Name5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name5.Location = new System.Drawing.Point(57, 216);
            this.Name5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name5.Name = "Name5";
            this.Name5.Size = new System.Drawing.Size(14, 20);
            this.Name5.TabIndex = 58;
            this.Name5.Text = "-";
            // 
            // Name4
            // 
            this.Name4.AutoSize = true;
            this.Name4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name4.Location = new System.Drawing.Point(57, 169);
            this.Name4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name4.Name = "Name4";
            this.Name4.Size = new System.Drawing.Size(14, 20);
            this.Name4.TabIndex = 57;
            this.Name4.Text = "-";
            // 
            // Name3
            // 
            this.Name3.AutoSize = true;
            this.Name3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name3.Location = new System.Drawing.Point(57, 126);
            this.Name3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name3.Name = "Name3";
            this.Name3.Size = new System.Drawing.Size(14, 20);
            this.Name3.TabIndex = 56;
            this.Name3.Text = "-";
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name2.Location = new System.Drawing.Point(57, 75);
            this.Name2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(14, 20);
            this.Name2.TabIndex = 55;
            this.Name2.Text = "-";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.Location = new System.Drawing.Point(57, 33);
            this.Name1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(14, 20);
            this.Name1.TabIndex = 54;
            this.Name1.Text = "-";
            // 
            // Score5
            // 
            this.Score5.AutoSize = true;
            this.Score5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score5.Location = new System.Drawing.Point(142, 216);
            this.Score5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score5.Name = "Score5";
            this.Score5.Size = new System.Drawing.Size(14, 20);
            this.Score5.TabIndex = 53;
            this.Score5.Text = "-";
            // 
            // Score4
            // 
            this.Score4.AutoSize = true;
            this.Score4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score4.Location = new System.Drawing.Point(142, 169);
            this.Score4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score4.Name = "Score4";
            this.Score4.Size = new System.Drawing.Size(14, 20);
            this.Score4.TabIndex = 52;
            this.Score4.Text = "-";
            // 
            // Score3
            // 
            this.Score3.AutoSize = true;
            this.Score3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score3.Location = new System.Drawing.Point(142, 126);
            this.Score3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score3.Name = "Score3";
            this.Score3.Size = new System.Drawing.Size(14, 20);
            this.Score3.TabIndex = 51;
            this.Score3.Text = "-";
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2.Location = new System.Drawing.Point(142, 75);
            this.Score2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(14, 20);
            this.Score2.TabIndex = 50;
            this.Score2.Text = "-";
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1.Location = new System.Drawing.Point(142, 33);
            this.Score1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(14, 20);
            this.Score1.TabIndex = 49;
            this.Score1.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLAYER NAME";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LOVE_SHOOT.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(924, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(940, 700);
            this.MinimumSize = new System.Drawing.Size(940, 678);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOVE SHOOT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer GameTimer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Name5;
        private System.Windows.Forms.Label Name4;
        private System.Windows.Forms.Label Name3;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Score5;
        private System.Windows.Forms.Label Score4;
        private System.Windows.Forms.Label Score3;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label label1;
    }
}