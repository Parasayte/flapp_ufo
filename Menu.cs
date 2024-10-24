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
        private void button2_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            Hide();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DimGray;
        }
        

    

        private void button3_Click_1(object sender, EventArgs e)
        {Option option = new Option();
            Hide();
            option.Show();
        }
    }
}