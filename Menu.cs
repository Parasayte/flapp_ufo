using System;
using System.Drawing;
using System.Windows.Forms;

namespace flapp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            Game game = new Game();
            game.Show();
            Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
          button1.BackColor = Color.DarkGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DimGray;
        }
    }
}