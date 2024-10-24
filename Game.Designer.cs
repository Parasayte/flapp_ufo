﻿namespace flapp
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer1 = new System.Timers.Timer();
            this.coloCHECKER = new System.Windows.Forms.PictureBox();
            this.coloCHECKER1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.PictureBox();
            this.colo1 = new System.Windows.Forms.PictureBox();
            this.colo = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloCHECKER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloCHECKER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // coloCHECKER
            // 
            this.coloCHECKER.BackColor = System.Drawing.Color.Transparent;
            this.coloCHECKER.InitialImage = null;
            this.coloCHECKER.Location = new System.Drawing.Point(766, -8);
            this.coloCHECKER.Name = "coloCHECKER";
            this.coloCHECKER.Size = new System.Drawing.Size(10, 466);
            this.coloCHECKER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coloCHECKER.TabIndex = 5;
            this.coloCHECKER.TabStop = false;
            // 
            // coloCHECKER1
            // 
            this.coloCHECKER1.BackColor = System.Drawing.Color.Transparent;
            this.coloCHECKER1.InitialImage = null;
            this.coloCHECKER1.Location = new System.Drawing.Point(397, -8);
            this.coloCHECKER1.Name = "coloCHECKER1";
            this.coloCHECKER1.Size = new System.Drawing.Size(10, 463);
            this.coloCHECKER1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coloCHECKER1.TabIndex = 17;
            this.coloCHECKER1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Azonix", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.InitialImage = null;
            this.player.Location = new System.Drawing.Point(36, 184);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(44, 44);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 22;
            this.player.TabStop = false;
            // 
            // colo1
            // 
            this.colo1.BackColor = System.Drawing.Color.Transparent;
            this.colo1.Image = ((System.Drawing.Image)(resources.GetObject("colo1.Image")));
            this.colo1.InitialImage = null;
            this.colo1.Location = new System.Drawing.Point(375, -192);
            this.colo1.Name = "colo1";
            this.colo1.Size = new System.Drawing.Size(59, 271);
            this.colo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colo1.TabIndex = 23;
            this.colo1.TabStop = false;
            // 
            // colo
            // 
            this.colo.BackColor = System.Drawing.Color.Transparent;
            this.colo.Image = ((System.Drawing.Image)(resources.GetObject("colo.Image")));
            this.colo.InitialImage = null;
            this.colo.Location = new System.Drawing.Point(742, 380);
            this.colo.Name = "colo";
            this.colo.Size = new System.Drawing.Size(65, 272);
            this.colo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colo.TabIndex = 24;
            this.colo.TabStop = false;
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel.Font = new System.Drawing.Font("Azonix", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.scorelabel.Location = new System.Drawing.Point(12, 9);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(168, 27);
            this.scorelabel.TabIndex = 25;
            this.scorelabel.Text = "Score : 0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(339, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 48);
            this.button2.TabIndex = 28;
            this.button2.Text = "Option";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Azonix", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 48);
            this.button1.TabIndex = 27;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Azonix", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(287, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Game Over";
            this.label1.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.colo);
            this.Controls.Add(this.colo1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.coloCHECKER1);
            this.Controls.Add(this.coloCHECKER);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloCHECKER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloCHECKER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox coloCHECKER1;

        private System.Windows.Forms.PictureBox colo1;

        public System.Timers.Timer timer1;

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox coloCHECKER;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.PictureBox colo;
    }
}

