using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dead_block
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Load_Game(object sender, EventArgs e)
        {
            GameScreen gamewindow = new GameScreen();
            gamewindow.Show();
        }

        private void load_help(object sender, EventArgs e)
        {
            HelpScreen hwindow = new HelpScreen();
            hwindow.Show();
        }
    }
}
