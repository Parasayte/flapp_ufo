using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace flapp
{
    public partial class Game : Form
    {
        public int colomnSpeed = Option.speed;
        public int gravity =Option.gravity1;
        public int jumpHigh = Option.jumphigh;
        private int time;
        private bool jumping;
        private int score = 0;
        public Game()
        {
            InitializeComponent();
        }
        private void Stages()
        {
            switch (score)
            {
                case 10:
                   
                    colomnSpeed += 4;
                    break;
                case 20:
                    gravity ++;
                    colomnSpeed += 4;
                    break;
                case 30:
                    colomnSpeed += 4;
                    break;
                case 40:
                   gravity ++;
                    colomnSpeed += 4;
                    break;
                case 50:
                    colomnSpeed += 4;
                    break;
                case 60:
                    colomnSpeed += 4;
                    break;
            }
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
            if (player.Location.Y <= 395 )
            {
                player.Top += time*gravity/5;
            }

            if (gravity==0)
            {
                time = 0;
            }
            if (player.Location.Y > 395 )
            {
                player.Location = new Point(player.Location.X, 395);
            }
            if (player.Location.Y < 1)
            {
                player.Location = new Point(player.Location.X, 1);
            }
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            label2.Text = "Cool : " + time;
            Gravity(player);
            UpColumn(colo);
            DownColumn(colo1);
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
        private void ScorePointer( )
        {
            score++;
            scorelabel.Text = "Score : " + score;
            Stages();
        }
        private void UpColumn(PictureBox colomn)
        {
            colomn.Left -= colomnSpeed;
            if (colomn.Left < 0)
            {
                ReplaceColomnUp(colomn);
                ScorePointer();
            }
        }
        private void DownColumn(PictureBox colomn )
        {
            colomn.Left -= colomnSpeed;
            if (colomn.Left < 0)
            {
              ReplaceColomnDown(colomn);
              ScorePointer();
            }
        }
        public void ReplaceColomnUp(PictureBox colomn )
        {
            Random random = new Random();
            int rnd=random.Next(249, 350);
            colomn.Left = 800;
            colomn.Top = +rnd;
        }
        public void ReplaceColomnDown(PictureBox colomn )
        {
            Random random = new Random();
            int rnd=random.Next(0, 209);
            colomn.Left = 800;
            colomn.Top = -rnd;
        }
        private void GameOver()
        {   
            button3.Visible=true;
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

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
