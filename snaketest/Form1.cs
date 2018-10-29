using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Media;
using System.Net;
using System.Diagnostics;

namespace snaketest
{
    public partial class Form1 : Form
    {
        /*
         * 4 for loops
         * 2 switch statements
         * ~13 else if statements
         * over 800 lines of code
        */
        
        WebClient webc = new WebClient();

        //rec for items
        Rectangle food = new Rectangle(); // food/apple
        Rectangle ghost = new Rectangle(); // ghost powerup
        Rectangle dp = new Rectangle(); // double point powerup
        Rectangle bonus = new Rectangle(); // bonus point powerup
        //end

        //player
        private Snake snake;
        //end

        //food
        double foodX; // food X coordinate
        double foodY; // food Y coordinate
        int rand1; // randnum X for food
        int rand2; // randnum Y for food
        //end

        //game stuff
        int points; // the points for the game
        bool paused = false; // checks if game is paused
        bool powerupsDisabled = false; // check if player disabled powerups
        static Random rand = new Random();
        bool gameOver = false; //gamover
        bool die = false; // we need this to play death sound
        bool stop = false; // also same for this
        bool showDebug = false; // show debug menu
        bool firstStart = true; // this isnt even used to check if first start anymore, but is needed.
        int lastScore = 0;
        int highScore = 0; 
        bool bounds = true; // disable bound/enable
        string difficulty = "Easy"; // default difficulty is easy.
        string currentUpdate = "102918dr5";
        string newUpdate;
        SoundPlayer _menselect; // menu select
        SoundPlayer _die; // death sound
        SoundPlayer _eat; // eat sound
        SoundPlayer _powerup; // powerup sound
        //end

        //difficulty
        bool esy = true;
        bool norm = false;
        bool hard = false;
        bool exp = false;
        //end

        //ghost powerup
        bool ghostmode = false;
        double randgx;
        double randgy;
        double gx = 999;
        double gy;
        int formgx = 999;
        int formgy;
        int timeLeftG;
        //end

        //double points
        double randdpx;
        double randdpy;
        double dpx = 999;
        double dpy;
        bool dpon = false;
        int formdpx = 999;
        int formdpy;
        int timeLeftDP;
        //end

        //bonus
        int bonusrx;
        int bonusry;
        int bonusformx = 999;
        int bonusformy;
        double bonusx = 999;
        double bonusy;
        bool bpon = false;
        int timeLeftBP;
        //end
        

        /*
         * 
         * (Some of the stuff not commented/explained was either because it is easy to understand or because I was to lazy to explain it.)
         * 
         * The guts of the game. I could have done a much better job organizing specific items into their own classes
         * but at this point, its far to late and would require a lot of time -- not worth it for me as almost everything
         * is currently working as intended. Not much purpose also because I'd say this class is pretty organized and
         * pretty easy to find what you are looking for.
         *
         * Current Issues: player is able to change to opposite direction if they hit a combination of buttons at the exact same time, effectively
         * killing the player. This can happen accidentely, without actually purposfully trying to do it. This will be extremely hard to fix.
         * A possible fix may just to be to almost completely rewrite direction function in Snake.cs
         * 
        */
        
        public Form1()
        {
            InitializeComponent();


            //Update Checker
            byte[] raw = webc.DownloadData("https://raw.githubusercontent.com/Creeperlover234/Snake-Game/master/release");

            newUpdate = Encoding.UTF8.GetString(raw);

            if (currentUpdate == newUpdate)
            {
                createdLabel.Text += "(latest build)";
                this.Text = "Snake (latest build)";
            }
            else
            {
                DialogResult UpdateYesNo = MessageBox.Show("There is a newer version of this application.\nWould you like to update?", "New Update", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if(UpdateYesNo == DialogResult.Yes)
                {
                    Process.Start("https://github.com/Creeperlover234/Snake-Game/releases");
                }
                else{}

                createdLabel.Text += "(old build)";
                this.Text = "Snake (old build)";
                createdLabel.Left += 10;
            }
            //End

            //below, we are initializing the sounds
            _die = new SoundPlayer(Properties.Resources.die);
            _eat = new SoundPlayer(Properties.Resources.eatfood);
            _powerup = new SoundPlayer(Properties.Resources.powerup);
            _menselect = new SoundPlayer(Properties.Resources.menselect);
            //end
            
            pictureBox1.BackColor = Color.Black; // set background of picturebox to black

            difEasy.Font = new Font(difEasy.Font.Name, difEasy.Font.SizeInPoints, FontStyle.Underline); // underline easy(default dif)

            snake = new Snake(); //create snake boi

            //set gameover to true on startup for a welcome message
            firstTime.Start(); // we start this timer to update current difficulty on startup, this timer is not used at all after startup.
            gameOver = true; // so gameover stuff does its stuff
            gmovLabel.Text = "  Welcome!";
            snake.Body[0].X = 777; //set snake off screen
            foodX = 899; // set food off-screen
            powerupTimer.Stop(); // stop powerup timer, so powerups dont keep spawning.
            gmovLabel.Visible = true; // show gameover textbox
            restartLabel.Visible = true; // show restart textbox

            //disable restart/pause buttons.
            pauseplayButton.Enabled = false;
            restartButton.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //This picturebox is the gameboard, this is what shows all the powerups and the snake.
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            snake.Draw(e.Graphics); //Draw snake on screen

            for (int x = 0; x < 32; x++) // draw grid behind picturebox
                for (int y = 0; y < 32; y++)
                    e.Graphics.DrawRectangle(Pens.Black, x * 20, y * 20, 20, 20); // 32 by 32 grid of 20 by 20 squares

            // Below we are creating Bitmaps for the powerups/items, this makes it extremely easy to manipulate the images.

            //apple
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.snakefood), food.X = (int)foodX, food.Y = (int)foodY, food.Width = 20, food.Height = 20);
            //ghost
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.ghostpowerup), ghost.X = (int)gx, ghost.Y = (int)gy, ghost.Width = 20, ghost.Height = 20);
            //double points
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.doublepoints), dp.X = (int)dpx, dp.Y = (int)dpy, dp.Width = 20, dp.Height = 20);
            //bonus points
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.bonuspoints), bonus.X = (int)bonusx, bonus.Y = (int)bonusy, bonus.Width = 20, bonus.Height = 20);
        }

        private void directionTimer_Tick(object sender, EventArgs e)
        {
            snake.Move(); // set direction of snake
            pictureBox1.Invalidate(); // update picturebox
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: // if gameover, pressing enter will restart the game.
                    if (gameOver)
                    {
                        if (gmovLabel.Text != "Game Over")
                            gmovLabel.Text = "Game Over";
                        if (points > highScore) // if your score was higher than the high score, set current score to high score.
                            highScore = points;

                        lastScore = points;
                        Restart(); // restart game
                        die = false; // set die to false, since we wont be dead anymore
                        stop = false;
                        foodEatTimer.Start(); // start food timer
                        directionTimer.Start(); // start direction timer
                        powerupTimer.Start(); // start powerup timers
                        gameOver = false; // set gamover to false
                        gmovLabel.Visible = false; // remove gameover text
                        restartLabel.Visible = false; // remove restart text
                        firstStart = false;
                        firstTime.Stop();
                    }
                    break;
                case Keys.Up: // changes direction to up
                case Keys.W:
                    if (snake.direction != Snake.Direction.Down && !gameOver && !paused)
                        snake.direction = Snake.Direction.Up;
                    break;
                case Keys.Down: // changes direction to down
                case Keys.S:
                    if (snake.direction != Snake.Direction.Up && !gameOver && !paused)
                        snake.direction = Snake.Direction.Down;
                    break;
                case Keys.Left: // changes direction to left
                case Keys.A:
                    if (snake.direction != Snake.Direction.Right && !gameOver && !paused)
                        snake.direction = Snake.Direction.Left;
                    break;
                case Keys.Right: // changes direction to right
                case Keys.D:
                    if (snake.direction != Snake.Direction.Left && !gameOver && !paused)
                        snake.direction = Snake.Direction.Right;
                    break;
                case Keys.Escape: // pause
                    if(!gameOver)
                        this.pauseplayButton_Click(sender, e); //simulate button press
                    break;
                case Keys.R: // restart
                    if (!gameOver && !paused)
                        restartButton_Click(sender, e);
                    if (gameOver)
                        SendKeys.Send("{Enter}"); // basically makes form think player pressed enter.
                    break;
                case Keys.F2: // debug mode
                    if (!showDebug)
                        showDebug = true;
                    else if (showDebug)
                        showDebug = false;
                    break;
                case Keys.Add: // snake grow for debug
                    if (showDebug)
                        snake.Grow();
                    break;
                case Keys.D1: // set dif to easy
                    difEasy_Click(sender, e);
                    break;
                case Keys.D2: // set dif to normal
                    difNorm_Click(sender, e);
                    break;
                case Keys.D3: // set dif to hard
                    difHard_Click(sender, e);
                    break;
                case Keys.D4: // set dif to expert
                    difExpert_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void foodEatTimer_Tick(object sender, EventArgs e) // if you can't tell, this timer is used for a lot more than just food.
        {

            for (int i = 1; i < snake.Body.Length; i++) // get length of snake
                if (snake.Body[0].IntersectsWith(snake.Body[i]) && !ghostmode) // if any part of snake collide with eachother, end game
                    gameOver = true;

            if (!bounds) //if player disabled bounds
            {
                /*
                 * 
                 * This disables bounds and allows the player to move to the other side of the screen, just like pacman.
                 * We teleport snake off screen for about half a frame just so we can make the animation feel just a bit more
                 * smoother, but, one side effect is that the player could easily time a movement change and get out of bounds.
                 * To prevent this, there is a timer that is started when a player moves out of bounds. This timer would give more
                 * than enough time to the player to get back in bounds if he/she was not trying to get out of bounds. But, if the
                 * player was trying to get our of bounds, the timer reconizes it and pushes the player back into the bounds.
                 * 
                */

                if (snake.Body[0].X < 0) // left side
                {
                    snake.Body[0].X = 520;
                    snake.Body[0].X += 20;
                }
                else if (snake.Body[0].X > 520) // right side
                {
                    snake.Body[0].X = 0;
                    snake.Body[0].X -= 20;
                }
                else if (snake.Body[0].Y < 0) // top
                {
                    snake.Body[0].Y = 520;
                    snake.Body[0].Y += 20;
                }
                else if (snake.Body[0].Y > 520) // bottom
                {
                    snake.Body[0].Y = 0;
                    snake.Body[0].Y -= 20;
                }

                //the point of the stuff below is to check if the player is off-screen for more than 110ms, if he is push him back on screen
                //this stops players from getting out of bounds and gives the teleportation feel a really nice smooth feeling to it.
                if (snake.Body[0].X > 520 || snake.Body[0].X < 0 || snake.Body[0].Y < 0 || snake.Body[0].Y > 520)
                    outOfBoundTimer.Start();
                else
                    outOfBoundTimer.Stop();

            }
            else // this is if player has not disabled bounds.
            {
                if (snake.Body[0].Y > 520 || snake.Body[0].X < 0 || snake.Body[0].Y < 0 || snake.Body[0].X > 520) // if snake goes off screen, end game
                    gameOver = true; //setting this bool to true effectively ends the game.
            }


            highScoreLabel.Text = "High Score: " + highScore; // update highscore
            pointsLabel.Text = "Score: " + points; // update score textbox
            lengthLabel.Text = "Length: " + snake.Body.Length; // update length of snake
            restartLabel.Text = "Press Enter or \'R\' to Restart.\n       Difficulty: " + difficulty; // update restart button based off of difficulty.

            if (snake.Body[0].IntersectsWith(food)) // eat food
            {
                _eat.Play(); // play eat sound


                //again, generate random x,y coord for food.
                genRandom();

                //points to add(powerups)
                if (dpon) // if we have double points
                {
                    points += 20; //add 20 points
                    snake.Grow(); // grow again, so double growth
                }
                else if(bpon)// if we have bonus points
                {
                    points += 30;
                }
                else
                {
                    points += 10;
                }

                snake.Grow();
            }else if (snake.Body[0].IntersectsWith(ghost))
            {
                _powerup.Play();
                ghostTimer.Stop(); // stop ghosttimer if started , should never happen
                ghostmode = true; // enable ghost
                gx = 999; // set powerup off screen
                formgx = 3; // set powerup on screen for powerup picbox
                formgy = 3; // same thing, just y coord
                timeLeftG = 8; // set time of powerup to 8 seconds
                gTimeLabel.Show(); // show time left label
                gTimeLabel.Text = "8 sec.";
                ghostPow.Invalidate(); // update pic box
                ghostTime.Start(); // start countdown timer.
                ghostTimer.Start(); // start ghost timer
            }else if (snake.Body[0].IntersectsWith(dp))
            {
                _powerup.Play();
                doublepointTimer.Stop(); // stop double point timer if started, should never happen.
                dpon = true; // obviously we need to enable powerup
                dpx = 999; // move powerup off screen
                timeLeftDP = 10;
                dpTime.Start(); // start timer
                dpTimeLabel.Show();
                dpTimeLabel.Text = "10 sec.";
                formdpx = 3;
                formdpy = 3;
                dpPow.Invalidate();
                doublepointTimer.Start();
            }else if (snake.Body[0].IntersectsWith(bonus))
            {
                _powerup.Play();
                bonuspointTimer.Stop();
                bpon = true;
                timeLeftBP = 15;
                bpTime.Start();
                bpTimeLabel.Show();
                bpTimeLabel.Text = "15 sec.";
                bonusx = 999;
                bonusformx = 3;
                bonusformy = 3;
                bonusPow.Invalidate();
                bonuspointTimer.Start();
            }

            if (gameOver) // if game is over, do code
            {
                snake.Body[0].X = 777; //set snake off screen
                powerupTimer.Stop(); // stop powerup timer, so powerups dont keep spawning.
                gmovLabel.Visible = true; // show gameover textbox
                restartLabel.Visible = true; // show restart textbox
                if (!stop) // we need this because since gameOver check is in a timer, death sound would play repeadately. Trust me, I destroyed my ears already.
                {
                    die = true;
                    stop = true;
                }
                firstStart = true;
                //Stop all time timers
                bpTime.Stop();
                outOfBoundTimer.Stop();
                bpTimeLabel.Hide();
                dpTime.Stop();
                dpTimeLabel.Hide();
                ghostTime.Stop();
                gTimeLabel.Hide();
                //disable difficulty buttons and restart/pause buttons.
                pauseplayButton.Enabled = false;
                restartButton.Enabled = false;
            }
            else
            {
                //re-enable buttons
                pauseplayButton.Enabled = true;
                restartButton.Enabled = true;
                difEasy.Enabled = true;
                difNorm.Enabled = true;
                difHard.Enabled = true;
                difExpert.Enabled = true;
            }

            if (die)
            {
                die = false;
                _die.Play();
            }

            if (showDebug) // for debug menuzzzzzzzzzzzzzzzzzzzzzzz
            {
                // there is not really a whole lot of purpose to this whole debug menu, can be helpful in finding the root cause to the quick direction
                //glitch.
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label15.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                label11.Show();
                label12.Show();
                label13.Show();
                label14.Show();
                label1.Text = "Direction: " + snake.direction;
                label2.Text = "Points: " + points;
                label3.Text = "Paused: " + paused;
                label4.Text = "Game Over: " + gameOver;
                label15.Text = "Powerup Disabled: " + powerupsDisabled;
                label6.Text = "Die: " + die;
                label7.Text = "Stop: " + stop;
                label8.Text = "Easy: " + esy;
                label9.Text = "Norm: " + norm;
                label10.Text = "Hard: " + hard;
                label11.Text = "Expert: " + exp;
                label12.Text = "GhostMode: " + ghostmode;
                label13.Text = "Double points: " + dpon;
                label14.Text = "Bonus points: " + bpon;

            }
            else if(!showDebug)
            {
                if (!label1.Visible)// I added this so this timer is not constantly hiding these labels when they're already hidden.
                    return;
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label15.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
            }

            
        }



        /*
         * Game functions -- Restart, and start
        */

        //in short, this function stops all timers and disables all powerups
        private void Restart()
        {
            //hide all countdown timers
            bpTimeLabel.Hide();
            dpTimeLabel.Hide();
            gTimeLabel.Hide();

            //update all pictureboxes
            ghostPow.Invalidate();
            dpPow.Invalidate();
            bonusPow.Invalidate();

            //reset snake
            snake = new Snake();
            snake.direction = Snake.Direction.Right;

            //generate random x,y for apple.
            genRandom();

            //disable all timers
            foodEatTimer.Stop();
            directionTimer.Stop();
            powerupTimer.Stop();
            outOfBoundTimer.Stop();
            dpTime.Stop();
            ghostTime.Stop();
            ghostTimer.Stop();
            doublepointTimer.Stop();
            bpTime.Stop();

            //set all bools to false
            die = false;
            stop = false;
            ghostmode = false;
            dpon = false;
            bpon = false;

            //set points to 0
            points = 0;

            //move all items off screen
            gx = 999;
            dpx = 999;
            bonusx = 999;
            bonusformx = 999;
            formgx = 999;
            formdpx = 999;
        }

        private void Start()
        {
            // start all timers and remove gameover labels and set to false
            foodEatTimer.Start();
            directionTimer.Start();
            powerupTimer.Start();
            stop = false;
            gmovLabel.Visible = false;
            restartLabel.Visible = false;
        }
        
        void genRandom()
        {
            rand1 = rand.Next(20, 500); // generate random X coord
            rand2 = rand.Next(20, 500); // generate random Y coord

            foodX = Math.Round(Math.Ceiling((float)rand1 / 20) * 20, MidpointRounding.ToEven); // set foodx to the random number
            foodY = Math.Round(Math.Ceiling((float)rand2 / 20) * 20, MidpointRounding.ToEven); // set foody to the random number
        }

        private void firstTime_Tick(object sender, EventArgs e)
        {
            restartLabel.Text = "Press Enter or R to Start.\n       Difficulty: " + difficulty;
        }

        private void outOfBoundTimer_Tick(object sender, EventArgs e) // this timer stops players from exiting the gameboard bounds when bounds are off.
        {
            if (snake.Body[0].X > 520)
                snake.Body[0].X = 0;
            else if (snake.Body[0].X < 0)
                snake.Body[0].X = 520;
            else if (snake.Body[0].Y > 520)
                snake.Body[0].Y = 0;
            else if (snake.Body[0].Y < 0)
                snake.Body[0].Y = 520;
        }

        /*
         * End -- Game functions 
        */




        /*
         *
         * Powerups -- Ghost, double points, and bonus points
         * Ghost - enables snake to go through its body for 8 seconds.
         * Double points - double the score and growth for 10 seconds.
         * Bonus points - x3 score for 15 seconds.
         * 
        */

        //this is timer, he makes all the powerups work.
        private void collisionTimer_Tick(object sender, EventArgs e)
        {
            if (powerupsDisabled) // if user disabled powerups, stop timer and return.
            {
                powerupTimer.Stop();
                return;
            }

            int randomNumber = 0;

            if (gx != 999) // set all powerups off screen if on screen. We do this because we dont want 2 or more powerups on screen.
                gx = 999;
            else if (dpx != 999)
                dpx = 999;
            else if (bonusx != 999)
                bonusx = 999;

            randomNumber = rand.Next(0, 8); //basically 37% chance of item drop.
            
            switch (randomNumber) // check random number
            {
                case 5: //ghost
                    randGhost();
                    pictureBox1.Invalidate();
                    break;
                case 4: //doublepoints
                    randDP();
                    pictureBox1.Invalidate();
                    break;
                case 6: //bonus points
                    randBP();
                    pictureBox1.Invalidate();
                    break;
            }

        }

        //Ghost power up start
        private void ghostPow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.ghostpowerup), formgx, formgy, 30, 30); // ghost bitmap for small pow-up picbox
        }

        void randGhost()
        {
            randgx = rand.Next(20, 500); // generate random X coord
            randgy = rand.Next(20, 500); // generate random Y coord

            gx = Math.Round(Math.Ceiling((float)randgx / 20) * 20, MidpointRounding.ToEven); // set gx to the random number
            gy = Math.Round(Math.Ceiling((float)randgy / 20) * 20, MidpointRounding.ToEven); // set gy to the random number

        }

        //timer
        private void testtimer_Tick(object sender, EventArgs e) // this timer will execute 8 seconds after picking up ghost powerup. it will disable it
        {
            ghostmode = false;
            formgx = 999;
            ghostPow.Invalidate();
            ghostTimer.Stop();
        }
        //ghost end

        //Double point stuff
        private void doublepointTimer_Tick(object sender, EventArgs e) // just like ghost, but lasts 10 seconds.
        {
            dpon = false;
            formdpx = 999;
            dpPow.Invalidate();
            doublepointTimer.Stop();
        }

        private void dpPow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.doublepoints), formdpx, formdpy, 30, 30);
        }

        void randDP()
        {
            randdpx = rand.Next(20, 500);  // generate random X coord
            randdpy = rand.Next(20, 500);  // generate random Y coord

            dpx = Math.Round(Math.Ceiling((float)randdpx / 20) * 20, MidpointRounding.ToEven); // set dpx to the random number
            dpy = Math.Round(Math.Ceiling((float)randdpy / 20) * 20, MidpointRounding.ToEven); // set dpy to the random number

        }
        //end double point

        //bonus point stuff
        private void bonuspointTimer_Tick(object sender, EventArgs e) // disable bonus points after 15 seconds.
        {
            bpon = false;
            bonusformx = 999;
            bonusPow.Invalidate();
            bonuspointTimer.Stop();
        }

        private void bonusPow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.bonuspoints), bonusformx, bonusformy, 30, 30);
        }

        void randBP()
        {
            bonusrx = rand.Next(20, 500); // generate random X coord
            bonusry = rand.Next(20, 500); // generate random Y coord

            bonusx = Math.Round(Math.Ceiling((float)bonusrx / 20) * 20, MidpointRounding.ToEven); // set bonusx to the random number
            bonusy = Math.Round(Math.Ceiling((float)bonusry / 20) * 20, MidpointRounding.ToEven); // set bonusy to the random number

        }
        //end bonus point

        private void ghostTime_Tick(object sender, EventArgs e) // countdown timer for the ghost powerup
        {

            if (timeLeftG != 0)
                timeLeftG -= 1;

            gTimeLabel.Text = "" + timeLeftG + " sec.";

            if (timeLeftG == 0)
            {
                ghostTime.Stop();
                gTimeLabel.Hide();
            }

        }

        private void dpTime_Tick(object sender, EventArgs e) // count down timer for double points
        {

            if (timeLeftDP != 0)
                timeLeftDP -= 1;

            dpTimeLabel.Text = "" + timeLeftDP + " sec.";

            if (timeLeftDP == 0)
            {
                dpTime.Stop();
                dpTimeLabel.Hide();
            }

        }

        private void bpTime_Tick(object sender, EventArgs e) // count down timer for bonus points.
        {
            if (timeLeftBP != 0)
                timeLeftBP -= 1;

            bpTimeLabel.Text = "" + timeLeftBP + " sec.";

            if (timeLeftBP == 0)
            {
                bpTime.Stop();
                bpTimeLabel.Hide();
            }
        }

        /*
         * End -- Powerups 
        */



        /*
         * Difficulty 
         * Easy, Normal, Hard, and Expert
         * collision issue is fixed -- dumb mistake on my part, didnt change timer interval for food timer.
         * I'm not gonna explain what this stuff does, should be plenty easy to understand already.
        */
        private void difEasy_Click(object sender, EventArgs e) // Easy
        {
            if (esy || paused)
                return;
            _menselect.Play();
            //set difficulty to easy
            esy = true;
            norm = false;
            hard = false;
            exp = false;
            directionTimer.Interval = 100;
            foodEatTimer.Interval = 100;
            outOfBoundTimer.Interval = 110;
            difEasy.Font = new Font(difEasy.Font.Name, difEasy.Font.SizeInPoints, FontStyle.Underline);
            difNorm.Font = new Font(difNorm.Font.Name, difNorm.Font.SizeInPoints, FontStyle.Regular);
            difHard.Font = new Font(difHard.Font.Name, difHard.Font.SizeInPoints, FontStyle.Regular);
            difExpert.Font = new Font(difExpert.Font.Name, difExpert.Font.SizeInPoints, FontStyle.Regular);
            if (!firstStart)
            {
                Restart();
                Start();
            }
            setDifficulty();
        }

        private void difNorm_Click(object sender, EventArgs e) // Normal
        {
            if (norm || paused)
                return;
            _menselect.Play();

            esy = false;
            norm = true;
            hard = false;
            exp = false;
            directionTimer.Interval = 70;
            foodEatTimer.Interval = 70;
            outOfBoundTimer.Interval = 80;
            difEasy.Font = new Font(difEasy.Font.Name, difEasy.Font.SizeInPoints, FontStyle.Regular);
            difNorm.Font = new Font(difNorm.Font.Name, difNorm.Font.SizeInPoints, FontStyle.Underline);
            difHard.Font = new Font(difHard.Font.Name, difHard.Font.SizeInPoints, FontStyle.Regular);
            difExpert.Font = new Font(difExpert.Font.Name, difExpert.Font.SizeInPoints, FontStyle.Regular);
            if (!firstStart)
            {
                Restart();
                Start();
            }
            setDifficulty();
        }

        private void difHard_Click(object sender, EventArgs e) // Hard
        {
            if (hard || paused)
                return;
            _menselect.Play();

            esy = false;
            norm = false;
            hard = true;
            exp = false;
            directionTimer.Interval = 60;
            foodEatTimer.Interval = 60;
            outOfBoundTimer.Interval = 70;
            difEasy.Font = new Font(difEasy.Font.Name, difEasy.Font.SizeInPoints, FontStyle.Regular);
            difNorm.Font = new Font(difNorm.Font.Name, difNorm.Font.SizeInPoints, FontStyle.Regular);
            difHard.Font = new Font(difHard.Font.Name, difHard.Font.SizeInPoints, FontStyle.Underline);
            difExpert.Font = new Font(difExpert.Font.Name, difExpert.Font.SizeInPoints, FontStyle.Regular);
            if (!firstStart)
            {
                Restart();
                Start();
            }
            setDifficulty();

        }

        private void difExpert_Click(object sender, EventArgs e) // Expert
        {
            if (exp || paused)
                return;
            _menselect.Play();

            esy = false;
            norm = false;
            hard = false;
            exp = true;
            directionTimer.Interval = 40;
            foodEatTimer.Interval = 40;
            outOfBoundTimer.Interval = 50;
            difEasy.Font = new Font(difEasy.Font.Name, difEasy.Font.SizeInPoints, FontStyle.Regular);
            difNorm.Font = new Font(difNorm.Font.Name, difNorm.Font.SizeInPoints, FontStyle.Regular);
            difHard.Font = new Font(difHard.Font.Name, difHard.Font.SizeInPoints, FontStyle.Regular);
            difExpert.Font = new Font(difExpert.Font.Name, difExpert.Font.SizeInPoints, FontStyle.Underline);
            if (!firstStart)
            {
                Restart();
                Start();
            }
            setDifficulty();
        }

        void setDifficulty()
        {
            if (esy)
                difficulty = "Easy";
            else if (norm)
                difficulty = "Normal";
            else if (hard)
                difficulty = "Hard";
            else if (exp)
                difficulty = "Expert";
        }

        /*
         * End--Dificulty
        */



        /*
         * Buttons: 
         * Restart, and pause buttons
        */
        private void restartButton_Click(object sender, EventArgs e) // restart button
        {
            _menselect.Play();
            Restart();
            Start();
        }

        private void pauseplayButton_Click(object sender, EventArgs e) // Pause/Play button
        {
            if(pauseplayButton.Text == "Pause")
            {
                _menselect.Play();
                directionTimer.Stop();
                foodEatTimer.Stop();
                powerupTimer.Stop();
                paused = true;
                restartButton.Enabled = false;
                difEasy.Enabled = false;
                difNorm.Enabled = false;
                difHard.Enabled = false;
                difExpert.Enabled = false;
                pauseplayButton.Text = "Play";
            }
            else
            {
                _menselect.Play();
                directionTimer.Start();
                foodEatTimer.Start();
                powerupTimer.Start();
                paused = false;
                restartButton.Enabled = true;
                difEasy.Enabled = true;
                difNorm.Enabled = true;
                difHard.Enabled = true;
                difExpert.Enabled = true;
                pauseplayButton.Text = "Pause";
            }
        }

        private void helpLabel_Click(object sender, EventArgs e) // Help button
        {
            HelpForm hf = new HelpForm();

            hf.ShowDialog(); // open help window
        }

        private void pictureBox1_Click(object sender, EventArgs e) // this literally does nothing
        {
            this.Focus();
        }

        private void disPowerups_Click(object sender, EventArgs e) // Disable powerups button
        {
            _menselect.Play();
            if (disPowerups.Text == "Powerups - On")
            {
                powerupsDisabled = true;
                disPowerups.Text = "Powerups - Off";
            }
            else
            {
                powerupsDisabled = false;
                powerupTimer.Start();
                disPowerups.Text = "Powerups - On";
            }
        }

        private void boundsLabel_Click(object sender, EventArgs e) // Disable/Enable bounds
        {
            _menselect.Play();
            if(boundsLabel.Text == "Bounds - On")
            {
                bounds = false;
                boundsLabel.Text = "Bounds - Off";
            }
            else
            {
                bounds = true;
                boundsLabel.Text = "Bounds - On";
            }
        }

        private void createdLabel_Click(object sender, EventArgs e)// clicking created by button
        {
            MessageBox.Show("Created by Carson Kelley\nLatest Build. Build#: " + currentUpdate, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*
         * End--Buttons 
        */


    }
}
