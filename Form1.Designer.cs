﻿namespace flapp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Timers.Timer();
            this.fish = new System.Windows.Forms.PictureBox();
            this.coloCHECKER = new System.Windows.Forms.PictureBox();
            this.scorelabel = new System.Windows.Forms.Label();
            this.colo = new System.Windows.Forms.PictureBox();
            this.coloCHECKER1 = new System.Windows.Forms.PictureBox();
            this.colo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloCHECKER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloCHECKER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // fish
            // 
            this.fish.BackColor = System.Drawing.Color.Transparent;
            this.fish.Image = ((System.Drawing.Image)(resources.GetObject("fish.Image")));
            this.fish.InitialImage = null;
            this.fish.Location = new System.Drawing.Point(22, 118);
            this.fish.Name = "fish";
            this.fish.Size = new System.Drawing.Size(46, 32);
            this.fish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fish.TabIndex = 3;
            this.fish.TabStop = false;
            this.fish.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // coloCHECKER
            // 
            this.coloCHECKER.BackColor = System.Drawing.Color.Transparent;
            this.coloCHECKER.InitialImage = null;
            this.coloCHECKER.Location = new System.Drawing.Point(766, -8);
            this.coloCHECKER.Name = "coloCHECKER";
            this.coloCHECKER.Size = new System.Drawing.Size(11, 466);
            this.coloCHECKER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coloCHECKER.TabIndex = 5;
            this.coloCHECKER.TabStop = false;
            this.coloCHECKER.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.Location = new System.Drawing.Point(12, 26);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(95, 27);
            this.scorelabel.TabIndex = 6;
            this.scorelabel.Text = "Score : 0";
            // 
            // colo
            // 
            this.colo.BackColor = System.Drawing.Color.Transparent;
            this.colo.Image = ((System.Drawing.Image)(resources.GetObject("colo.Image")));
            this.colo.InitialImage = null;
            this.colo.Location = new System.Drawing.Point(750, 392);
            this.colo.Name = "colo";
            this.colo.Size = new System.Drawing.Size(65, 272);
            this.colo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colo.TabIndex = 7;
            this.colo.TabStop = false;
            this.colo.Click += new System.EventHandler(this.colo_Click);
            // 
            // coloCHECKER1
            // 
            this.coloCHECKER1.BackColor = System.Drawing.Color.Transparent;
            this.coloCHECKER1.InitialImage = null;
            this.coloCHECKER1.Location = new System.Drawing.Point(381, -5);
            this.coloCHECKER1.Name = "coloCHECKER1";
            this.coloCHECKER1.Size = new System.Drawing.Size(10, 463);
            this.coloCHECKER1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coloCHECKER1.TabIndex = 9;
            this.coloCHECKER1.TabStop = false;
            // 
            // colo1
            // 
            this.colo1.BackColor = System.Drawing.Color.Transparent;
            this.colo1.Image = ((System.Drawing.Image)(resources.GetObject("colo1.Image")));
            this.colo1.InitialImage = null;
            this.colo1.Location = new System.Drawing.Point(354, -282);
            this.colo1.Name = "colo1";
            this.colo1.Size = new System.Drawing.Size(59, 271);
            this.colo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.colo1.TabIndex = 10;
            this.colo1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colo1);
            this.Controls.Add(this.coloCHECKER1);
            this.Controls.Add(this.colo);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.coloCHECKER);
            this.Controls.Add(this.fish);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloCHECKER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloCHECKER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox coloCHECKER1;

        private System.Windows.Forms.PictureBox colo1;

        public System.Timers.Timer timer1;

        #endregion

        private System.Windows.Forms.PictureBox fish;
        private System.Windows.Forms.PictureBox coloCHECKER;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.PictureBox colo;
    }
}
