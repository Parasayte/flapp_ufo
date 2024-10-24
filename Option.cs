using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace flapp
{
    public partial class Option : Form
    {
        private bool jumping;
        private int time;
        private int gravity1;
        private int jumphightry;
        public Option()
        {
            
            InitializeComponent();
            label3.Text = "Gravity : " + game.gravity;
        }
        Game game = new Game();
        
        private void Jump(int speed)
        {
            for (int i = 0; i < speed; i++)
            {
                player.Top -= speed*30;
               
            }
               
            time = 0;
        }
        private void JumpDown(int speed)
        {
            for (int i = 0; i < speed; i++)
            {
                player.Top += speed*30;
               
            }
               
            time = 0;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
            game.Show();
        }
        public void Gravity(PictureBox player)
        {
            if (player.Location.Y < 350 )
            {
                player.Top += time*gravity1/5;
               
            }
            else
            {
                time = 0;
                player.Location = new Point(player.Location.X, 350); // Ensure player stays on the ground
            }

            
            if (player.Location.Y < 1)
            {
                player.Location = new Point(player.Location.X, 0);
            }

           

        }
        private void button4_Click_1(object sender, EventArgs e)
        { 
            timer1.Start();
            game.gravity--;
            label3.Text = "Gravity : "+game.gravity;
            gravity1=game.gravity;
            time = 0;

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
         
            jumphightry = game.jumpHigh;
            game.gravity++;
            label3.Text = "Gravity : "+game.gravity;
           
            gravity1=game.gravity;
            time = 0;
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            time++;
            Gravity(player);
           
        }

      

        private void button5_Click_1(object sender, EventArgs e)
        {
            Jump(jumphightry);
        }

        private void Option_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
           JumpDown(jumphightry);
        }
    }
}