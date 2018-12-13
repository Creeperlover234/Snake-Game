using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace snaketest
{
    public partial class HelpForm : MaterialForm
    {

        private int onPage = 1;
        private bool onItemPage = true;
        private bool onControlPage = false;

        /*
         *
         * Completley rewrote this help form. A lot better than it was before and plus,
         * it's using the materialform instead of the default windows form so it looks
         * a lot better. These pages work by moving other images off screen and when
         * we go to a different page we move previous page info off screen and move
         * new pictures to screen and change the info text boxes.
         * 
         * ex: going from p1 to p2, move apple and ghost image off screen, then, move bonus and double point pic on screen,
         * finally, change the text box descriptions to fit the powerups on screen.
         * 
        */

        public HelpForm()
        {
            InitializeComponent();
            //disable page1 button cus we are on that page by default.
            page1button.Enabled = false;
            
            //initialize materialform
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, 0, TextShade.WHITE);
            //end

            //move all other page info off screen
            bonuspointInf.Top = 999;
            doublePointInfo.Top = 999;
            slowdownTimeBox.Top = 999;
            controlLabel.Top = 999;
            buttonWimage.Top = 999;
            buttonAimage.Top = 999;
            buttonSimage.Top = 999;
            buttonDimage.Top = 999;
        }

        private void ghostPow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.snakefood), 3, 3, 30, 30);
        }

        private void ghostInf_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.ghostpowerup), 3, 3, 30, 30);
        }

        private void doublePointInfo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.doublepoints), 3, 3, 30, 30);
        }

        private void bonuspointInf_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.bonuspoints), 3, 3, 30, 30);
        }

        private void slowdownTimeBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.slowdowntime), 3, 3, 30, 30);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.snakefood), 3, 3, 140, 140);
        }

        private void gotoPage1()
        {
            bonuspointInf.Top = 999; // orig: 145, 75
            doublePointInfo.Top = 999; // orig: 145, 240
            slowdownTimeBox.Top = 999;

            applInf.Top = 75;
            applInf.Left = 145;
            ghostInf.Top = 240;
            ghostInf.Left = 145;

            infoBox1.Top = 118;
            infoBox2.Top = 285;

            infoBox1.Text = "This is an apple. Your objective  is to eat  this apple.\nEach time you eat this apple,  it will move somewhere\nelse on the gameboard. You will notice as you eat\nmore and more of these apples, your snake slowly\ngrows. Eat these apples to gain points and grow\nyour snake!";
            infoBox2.Text = "This is the ghost powerup. When eaten, your snake \nbecomes a ghost. This allows your snake to go\nright through your body without dying. This can\ngive an significant advantage on higher difficulties.\nBut, watch out. This powerup only lasts 8 seconds!";

            this.Height = 390;

            page1button.Enabled = false;
            page2button.Enabled = true;
            page3button.Enabled = true;

            onPage = 1;
        }

        private void gotoPage2()
        {
            //move applepic and ghostpic and info for the two off screen.

            applInf.Top = 999; // orig: 145, 75
            ghostInf.Top = 999; // orig: 145, 240
            slowdownTimeBox.Top = 999;

            bonuspointInf.Top = 75;
            bonuspointInf.Left = 145;

            doublePointInfo.Top = 240;
            doublePointInfo.Left = 145;
            
            infoBox1.Top = 118;
            infoBox2.Top = 285;

            this.Height = 405;

            infoBox1.Text = "This powerup is Bonus Points. This powerup will help\nyou gain more points and get the highest score\npossible. Unlike double points, this powerup triples\nthe amount of points you gain when you eat an apple.\nThough, you do not grow larger than normal.\nThis powerup lasts 15 seconds.";
            infoBox2.Text = "This powerup is Double Points. This powerup will give\nyour snake the ability to grow x2 the speed.\nWhen you eat an apple, not only do you gain 20 points\ninstead of 10, but, you also grow twice.\nAgain, be mindful of how long this powerup lasts.\nThis powerup only lasts 10 seconds.";
            
            page1button.Enabled = true;
            page2button.Enabled = false;
            page3button.Enabled = true;

            onPage = 2;
        }

        private void gotoPage3()
        {

            applInf.Top = 999; // orig: 145, 75
            ghostInf.Top = 999; // orig: 145, 240
            bonuspointInf.Top = 999; // orig: 145, 75
            doublePointInfo.Top = 999; // orig: 145, 240
            
            slowdownTimeBox.Top = 145;
            slowdownTimeBox.Left = 145;

            //info orig pos: 140, 118

            infoBox1.Top = 190;
            infoBox2.Top = 285;

            infoBox1.Text = "This is the \"Down Clock\" powerup. When this item is\neaten, the snake and the game will suddenly slow\ndown! This powerup can particarally be helpful when\non harder difficulties. This powerup only lasts 10\nseconds, so be careful!";
            infoBox2.Text = "";

            this.Height = 390;

            page1button.Enabled = true;
            page2button.Enabled = true;
            page3button.Enabled = false;

            onPage = 3;
        }

        private void page1button_Click(object sender, EventArgs e)
        {
            gotoPage1();
        }

        private void page2button_Click(object sender, EventArgs e)
        {
            gotoPage2();
        }

        private void page3Button_Click(object sender, EventArgs e)
        {
            gotoPage3();
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            if (onItemPage)
                return;

            if (onPage == 1)
                gotoPage1();
            else if (onPage == 2)
                gotoPage2();
            else if (onPage == 3)
                gotoPage3();

            page1button.Show();
            page2button.Show();
            page3button.Show();

            controlLabel.Top = 999;

            buttonWimage.Top = 999;
            buttonAimage.Top = 999;
            buttonSimage.Top = 999;
            buttonDimage.Top = 999;

            onItemPage = true;
            onControlPage = false;
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            if (onControlPage)
                return;

            //w 310, 72
            //a 264, 118
            //s 310, 118
            //d 357, 118

            applInf.Top = 999; // orig: 145, 75
            ghostInf.Top = 999; // orig: 145, 240
            bonuspointInf.Top = 999;
            doublePointInfo.Top = 999;
            slowdownTimeBox.Top = 999;
            infoBox1.Top = 999;
            infoBox2.Top = 999;

            page1button.Hide();
            page2button.Hide();
            page3button.Hide();

            controlLabel.Top = 180;
            controlLabel.Left = 220;


            buttonWimage.Top = 72;
            buttonAimage.Top = 118;
            buttonSimage.Top = 118;
            buttonDimage.Top = 118;
            buttonWimage.Left = 310;
            buttonAimage.Left = 264;
            buttonSimage.Left = 310;
            buttonDimage.Left = 357;

            this.Height = 390;

            onItemPage = false;
            onControlPage = true;
        }

        private void buttonWimage_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 20))
            {
                e.Graphics.DrawString("W", myFont, Brushes.White, new Point(0, 2));
            }
        }

        private void buttonAimage_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 20))
            {
                e.Graphics.DrawString("A", myFont, Brushes.White, new Point(4, 2));
            }
        }

        private void buttonSimage_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 20))
            {
                e.Graphics.DrawString("S", myFont, Brushes.White, new Point(4, 2));
            }
        }

        private void buttonDimage_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 20))
            {
                e.Graphics.DrawString("D", myFont, Brushes.White, new Point(4, 2));
            }
        }
    }
}