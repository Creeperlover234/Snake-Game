using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace snaketest
{
    class Enemy
    {
        //yes, this is copy-pasted from snake.cs no point in rewriting code that was already written.
        public Rectangle[] AIBody; // body of enemy, needs to be array so we can add to it.
        int speed = 20;
        public enum DirectionAI { Up, Down, Left, Right, NONE };
        public DirectionAI directionAI;
        LinearGradientBrush bodyColor = new LinearGradientBrush(new Point(-10, 550), new Point(560, -10), Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 0, 0, 255));
        LinearGradientBrush headColor = new LinearGradientBrush(new Point(-10, 550), new Point(560, -10), Color.FromArgb(255, 0, 230, 255), Color.FromArgb(205, 135, 0, 255));
        private int x = 260;
        private int y = 260;
        private int width = 20;
        private int height = 20;


        /*
         * 
         * This class is for the enemy AI. This is literally almost completley copy-pasted from the Snake.cs class
         * because I see no purpose in completely rewriting something that is already done. It makes it easier to
         * get this done. Anyways, this is just for the enemy that trys to steal your apples.
         * 
        */

        public Enemy()
        {
            AIBody = new Rectangle[1];
            AIBody[0] = new Rectangle(x, y, width, height); // draw enemy
        }

        public void UpdateBody()
        {
            for (int i = AIBody.Length - 1; i > 0; i--) //odd flex but ok
                AIBody[i] = AIBody[i - 1];
        }

        public void Draw(Graphics g)
        {
            for (int i = AIBody.Length - 1; i > 0; i--)
                g.FillEllipse(Brushes.Red, AIBody[i]);

            g.FillEllipse(Brushes.DarkRed, AIBody[0]);

        }

        public void Grow() // creates new rectangle to snake array, in essence, the enemy 'grows'
        {
            List<Rectangle> bodyAdd = AIBody.ToList();
            bodyAdd.Add(new Rectangle(AIBody[AIBody.Length - 1].X, AIBody[AIBody.Length - 1].Y, width, height));
            bodyAdd.Add(new Rectangle(AIBody[AIBody.Length - 1].X, AIBody[AIBody.Length - 1].Y, width, height));
            AIBody = bodyAdd.ToArray();
        }

        public void Move()
        {
            UpdateBody();
            switch (directionAI)
            {
                case DirectionAI.Up:
                    AIBody[0].Y -= speed;
                    break;
                case DirectionAI.Down:
                    AIBody[0].Y += speed;
                    break;
                case DirectionAI.Left:
                    AIBody[0].X -= speed;
                    break;
                case DirectionAI.Right:
                    AIBody[0].X += speed;
                    break;
                case DirectionAI.NONE:
                    AIBody[0].X += 0;
                    AIBody[0].Y += 0;
                    break;
                default:
                    break;
            }
        }

    }
}

