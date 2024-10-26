using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace flapp
{
    public partial class Game : Form
    {
        public int ColumnSpeed = Option.Speed;
        public int GravityGame =Option.Gravity1;
        public int JumpHigh = Option.Jumphigh;
        private int _gravityTime;
        private int _playerScore;
        public Game()
        {
            InitializeComponent();
        }
        private void Stages()
        {
            switch (_playerScore)
            {
                case 10:
                   
                    ColumnSpeed += 4;
                    break;
                case 20:
                    GravityGame ++;
                    ColumnSpeed += 4;
                    break;
                case 30:
                    ColumnSpeed += 4;
                    break;
                case 40:
                   GravityGame ++;
                    ColumnSpeed += 4;
                    break;
                case 50:
                    ColumnSpeed += 4;
                    break;
                case 60:
                    ColumnSpeed += 4;
                    break;
            }
        }
        private static bool Crashing(PictureBox p,PictureBox c )
        {
            if (p.Bounds.IntersectsWith(c.Bounds))
            {
                return true;
            }
            return false;
        }

        private void Gravity(PictureBox playerPictureBox)
        {
            if (playerPictureBox.Location.Y <= 395 )
            {
                playerPictureBox.Top += _gravityTime*GravityGame/5;
            }

            if (GravityGame==0)
            {
                _gravityTime = 0;
            }
            if (playerPictureBox.Location.Y > 395 )
            {
                playerPictureBox.Location = new Point(playerPictureBox.Location.X, 395);
            }
            if (playerPictureBox.Location.Y < 1)
            {
                playerPictureBox.Location = new Point(playerPictureBox.Location.X, 1);
            }
        }
        private void Game_loop(object sender, ElapsedEventArgs e)
        {
            frames_counter.Text = @"Cool : " + _gravityTime;
            Gravity(player);
            UpColumn_movement(colo_up);
            DownColumn_movement(colo_downn);
            if (Crashing(player, colo_up) || Crashing(player, colo_downn))
            {
                restart_button.Enabled = true;
                GameOver();
            }
            _gravityTime++;
        }
        private void JumpDown(int speed)
        {
            for (int i = 0; i < speed; i++)
            {
                player.Top += speed*10;
            }
            _gravityTime = 0;
        }
        private void JumpUp(int speed)
        {
            for (int i = 0; i < speed; i++)
            {
                player.Top -= speed*10;
            }
            _gravityTime = 0;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
               JumpUp(JumpHigh);
            if(e.KeyCode==Keys.Down)
                JumpDown(JumpHigh);
        }
        private void ScorePointer( )
        {
            _playerScore++;
            scorelabel.Text = @"Score : " + _playerScore;
            Stages();
        }
        private void UpColumn_movement(PictureBox column)
        {
            column.Left -= ColumnSpeed;
            if (column.Left < 0)
            {
                ReplaceColomnUp(column);
                ScorePointer();
            }
        }
        private void DownColumn_movement(PictureBox column )
        {
            column.Left -= ColumnSpeed;
            if (column.Left < 0)
            {
              ReplaceColomnDown(column);
              ScorePointer();
            }
        }

        private void ReplaceColomnUp(PictureBox colomn )
        {
            Random random = new Random();
            int rnd=random.Next(249, 350);
            colomn.Left = 800;
            colomn.Top = +rnd;
        }

        private void ReplaceColomnDown(PictureBox colomn )
        {
            Random random = new Random();
            int rnd=random.Next(0, 209);
            colomn.Left = 800;
            colomn.Top = -rnd;
        }
        private void GameOver()
        {   
            menu_button.Visible=true;
            option_button.Enabled = true;
            game_over.Visible = true;
            restart_button.Visible = true;
            timer1.Stop();
            option_button.Visible = true;
        }
        private void Restart()
        {
            option_button.Visible = false;
            option_button.Enabled = false;
            menu_button.Visible = false;
            restart_button.Enabled = false;
            game_over.Visible = false;
            restart_button.Visible = false;
            timer1.Start();
            _playerScore = 0;
            
        Close();
        Game game = new Game();
        game.Show();
        }
        private void Menu_button(object sender, EventArgs e)
        { 
            Close();
            Menu m = new Menu();
            m.Show();
        }
        private void Restart_button(object sender, EventArgs e)
        {
            Restart();
        }
        private void Option_button(object sender, EventArgs e)
        {
            Close();
            Option o = new Option();
            o.Show();
        }
    }
}
