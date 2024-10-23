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
        private int gravity = 1;
        private int speed = 6;
        private int time;
        private bool jumping,alive;
        public Form1()
        {
            
            InitializeComponent();
         
          
        }
        
        
      

        
        
       

        private bool Crashing(Label p,Label c )
        {
            if (p.Bounds.IntersectsWith(c.Bounds))
            {
                Console.WriteLine(@"Crashing");
                return true;
            }
            return false;
        }


        private void Jump(int speed)
        {
            
               player.Top -= speed*30;
            time = 0;
        }

        private void Gravity()
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
               Jump(1);
                jumping = false;
            }
                
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Column(enemy);
          Gravity();
         if (Crashing(player,enemy))
             timer1.Stop();
        time++;
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
                jumping = true;
                
           
        }

        private void Column(Label enemy)
        {
            Random random = new Random();
            enemy.Left -= 20;
            if (enemy.Left < 0)
            {
                enemy.Left = 900;
                enemy.Top = random.Next(5, 390);
            }
                
            
        }
       

    }
}
