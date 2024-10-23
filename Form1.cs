using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Timer = System.Timers.Timer;

namespace flapp
{
    public partial class Form1 : Form
    {
        private int gravity = 4;
        private int speed = 6;
        private int time;
        private bool jumping,alive=true;
        private int score = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

    
        
      

        
        
       

        private bool Crashing(PictureBox p,PictureBox c )
        {
            if (p.Bounds.IntersectsWith(c.Bounds))
            {
                
                return true;
            }
            return false;
        }
        private void Gravity()
        {
            if (fish.Location.Y < 395 )
            {
                fish.Top += time*gravity/5;
                if (time * gravity  > 395)
                    time --;
            }
            
            if (fish.Location.Y < 1)
            {
                fish.Location = new Point(fish.Location.X, 0);
            }

            if (jumping)
            {
                Jump(1);
                jumping = false;
            }

        }

        private void Jump(int speed)
        {
            for (int i = 0; i < speed; i++)
            {
                fish.Top -= speed*30;
            }
               
            time = 0;
        }

       

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {  
            
            Gravity();
            UpColumn(colo,coloCHECKER);
            DownColumn(colo1,coloCHECKER1);
         
         if (Crashing(fish,colo)||Crashing(fish,colo1))
             timer1.Stop(); 
         time++;
        }
        


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
                jumping = true;
               
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void enemy_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        private void ScoreChecker( PictureBox coloCHECKER)
        {
            if (fish.Bounds.IntersectsWith(coloCHECKER.Bounds))
            {
                score++;
                
            }
scorelabel.Text = "Score : " + score/3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void colo_Click(object sender, EventArgs e)
        {

        }
       
        private void UpColumn(PictureBox colomn,PictureBox scorecheck)
        {
            ScoreChecker(scorecheck);
            Random random = new Random();
            colomn.Left -= 20;
            scorecheck.Left -= 20;
            if (colomn.Left < 0)
            {
                int rnd=random.Next(249, 350);
                colomn.Left = 800;
                scorecheck.Left = 826;
             
                colomn.Top = rnd;
            }
                
            
        }
        private void DownColumn(PictureBox colomn ,PictureBox scorecheck)
        {
            
            ScoreChecker(scorecheck);
            Random random = new Random();
            colomn.Left -= 20;
            scorecheck.Left -= 20;
            if (colomn.Left < 0)
            {
                int rnd=random.Next(0, 209);
                colomn.Left = 800;
                scorecheck.Left = 826;
             
                colomn.Top = -rnd;
            }
                
            
        }


     
    }
}
