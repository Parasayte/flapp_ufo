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
        public static int gravity1=2;
        public static  int jumphigh=1;
        public static int speed=8;
        public Option()
        {
            InitializeComponent();
            label3.Text = "Gravity : " + gravity1;
            label4.Text = "game Speed : " + speed;
            label5.Text = "Jump High : " + jumphigh;
        }
        Game game = new Game();
        
        private void JumpUp(int speed)
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

            game.colo.Location = new Point(742, 380);
            game.colo1.Location = new Point(375, -192);
            Close();
            game.Show();
        }
        public void Gravity(PictureBox player)
        {
            if (player.Location.Y <= 350 )
            {
                player.Top += time*gravity1/5;
            }

            if (player.Location.Y > 350 )
            {
                player.Location = new Point(player.Location.X, 350);
            }

            if (gravity1 == 0)
            {
                time = 0;
            }
            
            if (player.Location.Y < 1)
            {
                player.Location = new Point(player.Location.X, 1);
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        { 
            timer1.Start();
            gravity1--;
            label3.Text = "Gravity : "+gravity1;
            game.gravity=  gravity1;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            jumphigh = game.jumpHigh;
            gravity1++;
            label3.Text = "Gravity : "+gravity1;
           game.gravity =gravity1;
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            time++;
            Gravity(player);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            JumpUp(jumphigh);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           JumpDown(jumphigh);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            speed++;
            label4.Text = "game Speed : " + speed;
            game.colomnSpeed= speed;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if(speed>1)
            { 
                speed--;
                label4.Text = "game Speed : " + speed;
                game.colomnSpeed= speed;
            }
        }

        private void Option_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(jumphigh<4)
            {
                jumphigh++;
                label5.Text = "Jump High : " + jumphigh;
                game.jumpHigh = jumphigh;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(jumphigh>1)
            {
                jumphigh--;
                label5.Text = "Jump High : " + jumphigh;
                game.jumpHigh = jumphigh;
            }
        }
    }
}