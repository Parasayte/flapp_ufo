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
    public partial class Game : Form
    {
        private int colomnSpeed = 20;
        public int gravity ;
        public int jumpHigh = 1;
        private int time;
        private bool jumping,alive=true;
        private int score = 0;

        public Game()
        {
           
          
            InitializeComponent();
            gravity = 1;
        }

    
        
      

        
        
       

        private bool Crashing(PictureBox p,PictureBox c )
        {
            if (p.Bounds.IntersectsWith(c.Bounds))
            {
               
                return true;
            }
            return false;
        }
        
        public void Gravity(PictureBox player)
        {
            if (player.Location.Y < 395 )
            {
                player.Top += time*gravity/5;
                if (time * gravity  > 395)
                    time --;
            }
            
            if (player.Location.Y < 1)
            {
                player.Location = new Point(player.Location.X, 0);
            }

            if (jumping)
            {
                Jump(jumpHigh);
                jumping = false;
            }

        }

        private void Jump(int speed)
        {
            for (int i = 0; i < speed; i++)
            {
                player.Top -= speed*30;
               
            }
               
            time = 0;
        }

       

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {  
            
            Gravity(player);
            UpColumn(colo,coloCHECKER);
            DownColumn(colo1,coloCHECKER1);

            if (Crashing(player, colo) || Crashing(player, colo1))
            {
                button1.Enabled = true;
                GameOver();
            }

            time++;
        }
        
        private void JumpDown(int speed)
        {
            for (int i = 0; i < speed; i++)
            {
                player.Top += speed*30;
               
            }
               
            time = 0;
        }
        private void JumpUp(int speed)
        {
            for (int i = 0; i < speed; i++)
            {
                player.Top -= speed*30;
               
            }
               
            time = 0;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
               JumpUp(jumpHigh);
            if(e.KeyCode==Keys.Down)
                JumpDown(jumpHigh);
        }

       

      
        private void ScoreChecker( PictureBox coloCHECKER)
        {
            if (player.Bounds.IntersectsWith(coloCHECKER.Bounds))
            {
                score+=1;
               
            }

           
scorelabel.Text = "Score : " + score/3;
        }

        

        
       
        private void UpColumn(PictureBox colomn,PictureBox scorecheck)
        {
            ScoreChecker(scorecheck);
           
            colomn.Left -= colomnSpeed;
            scorecheck.Left -= colomnSpeed;
            if (colomn.Left < 0)
            {
                ReplaceColomnUp(colomn,scorecheck);
            }
                
            
        }
        private void DownColumn(PictureBox colomn ,PictureBox scorecheck)
        {
            
            ScoreChecker(scorecheck);
           
            colomn.Left -= colomnSpeed;
            scorecheck.Left -= colomnSpeed;
            if (colomn.Left < 0)
            {
              ReplaceColomnDown(colomn,scorecheck);
            }
                
            
        }

        private void ReplaceColomnUp(PictureBox colomn ,PictureBox scorecheck)
        {
            Random random = new Random();
            int rnd=random.Next(249, 350);
            colomn.Left = 800;
            scorecheck.Left = 816;
             
            colomn.Top = +rnd;
        }
        private void ReplaceColomnDown(PictureBox colomn ,PictureBox scorecheck)
        {
            Random random = new Random();
            int rnd=random.Next(0, 209);
            colomn.Left = 800;
            scorecheck.Left = 816;
             
            colomn.Top = -rnd;
        }
        
        private void GameOver()
        {button3.Visible=true;
            button2.Enabled = true;
            label1.Visible = true;
            button1.Visible = true;
            timer1.Stop();
            button2.Visible = true;
        }
        private void Restart()
        {
            button2.Visible = false;
            button2.Enabled = false;
button3.Visible = false;
            button1.Enabled = false;
            Jump(jumpHigh);
            label1.Visible = false;
            button1.Visible = false;
            timer1.Start();
            score = 0;
        Close();
        Game game = new Game();
        game.Show();
        }

      
     

     

        private void button3_Click_2(object sender, EventArgs e)
        { 
            Close();
            Menu m = new Menu();
            m.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Restart();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
            Option o = new Option();
            o.Show();
            
        }
    }
}
