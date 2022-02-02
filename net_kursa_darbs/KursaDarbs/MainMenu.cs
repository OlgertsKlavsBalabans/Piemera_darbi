using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursaDarbs
{
    public partial class mnuMainMenu : Form
    {
        public mnuMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            frmScore score = new frmScore();
            score.Show();
            this.Hide();
        }
    }
}
