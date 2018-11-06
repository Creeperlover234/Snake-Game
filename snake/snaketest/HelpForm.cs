using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snaketest
{
    public partial class HelpForm : Form
    {

        /*
         *
         * By far, the easiest part of this game.
         * All we do is create a bitmap of all the powerups/items and draw them to their designated picturebox
         * then give information about them. Very simple.
         * 
        */

        public HelpForm()
        {
            InitializeComponent();
        }

        private void ghostPow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.snakefood), 3, 3, 30, 30);
        }

        private void ghostInf_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.ghostpowerup), 3, 3, 30, 30);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void doublePointInfo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.doublepoints), 3, 3, 30, 30);
        }

        private void bonuspointInf_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.bonuspoints), 3, 3, 30, 30);
        }
    }
}
