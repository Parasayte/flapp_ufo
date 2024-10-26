using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace flapp
{
    public partial class Option : Form
    {
        private int _time;
        public static int Gravity1=5;
        public static  int Jumphigh=2;
        public static int Speed=12;
        public Option()
        {
            InitializeComponent();
            label3.Text = @"Gravity : " + Gravity1;
            label4.Text = @"game Speed : " + Speed;
            label5.Text = @"Jump High : " + Jumphigh;
        }
        Game _game = new Game();
        
        private void JumpUp(int jumpHigh)
        {
            for (int i = 0; i < jumpHigh; i++)
            {
                player_pictureBox.Top -= jumpHigh*10;
            }
               
            _time = 0;
        }
        private void JumpDown(int jumpHigh)
        {
            for (int i = 0; i < jumpHigh; i++)
            {
                player_pictureBox.Top += jumpHigh*10;
            }
            _time = 0;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            _game.colo_up.Location = new Point(742, 380);
            _game.colo_downn.Location = new Point(375, -192);
            Close();
            _game.Show();
        }

        private void Gravity(PictureBox player)
        {
            if (player.Location.Y <= 350 )
            {
                player.Top += _time*Gravity1/5;
            }

            if (player.Location.Y > 350 )
            {
                player.Location = new Point(player.Location.X, 350);
            }

            if (Gravity1 == 0)
            {
                _time = 0;
            }
            
            if (player.Location.Y < 1)
            {
                player.Location = new Point(player.Location.X, 1);
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        { 
            timer1.Start();
            Gravity1--;
            label3.Text = @"Gravity : "+Gravity1;
            _game.GravityGame=  Gravity1;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            Jumphigh = _game.JumpHigh;
            Gravity1++;
            label3.Text = @"Gravity : "+Gravity1;
           _game.GravityGame =Gravity1;
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            _time++;
            Gravity(player_pictureBox);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            JumpUp(Jumphigh);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           JumpDown(Jumphigh);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Speed++;
            label4.Text = @"game Speed : " + Speed;
            _game.ColumnSpeed= Speed;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if(Speed>1)
            { 
                Speed--;
                label4.Text = @"game Speed : " + Speed;
                _game.ColumnSpeed= Speed;
            }
        }

        private void Option_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(Jumphigh<6)
            {
                Jumphigh++;
                label5.Text = @"Jump High : " + Jumphigh;
                _game.JumpHigh = Jumphigh;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(Jumphigh>1)
            {
                Jumphigh--;
                label5.Text = @"Jump High : " + Jumphigh;
                _game.JumpHigh = Jumphigh;
            }
        }
    }
}