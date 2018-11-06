using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace snaketest
{
    class Enemy
    {
        public Rectangle[] AIBody; // body of snake, needs to be array so we can add to it.
        int speed = 20; // default speed of snake
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
         * This is the class for the snake. Most of this stuff is pretty self-explanatory.
         * We create a rectangle array, when draw function is called, draw the snake.
         * When Grow method is called, we add another rectangle to the array. -- this would not be possible without an rectangle array.
         * Move method, obviously sets direction the snake is going in.
         * 
        */

        public Enemy()
        {
            AIBody = new Rectangle[1];
            AIBody[0] = new Rectangle(x, y, width, height); // for drawing snake
        }

        public void UpdateBody()
        {
            for (int i = AIBody.Length - 1; i > 0; i--) //odd flex but ok
                AIBody[i] = AIBody[i - 1];
        }

        public void Draw(Graphics g)
        {
            for (int i = AIBody.Length - 1; i > 0; i--)
                g.FillEllipse(Brushes.Red, AIBody[i]); // MOAR CIRCLEZZZZZ

            g.FillEllipse(Brushes.Tomato, AIBody[0]); // CIRCLES

        }

        public void Grow() // creates new rectangle to snake array, in essence, the snake 'grows'
        {
            List<Rectangle> bodyAdd = AIBody.ToList(); // we do this to make life easier ;)
            bodyAdd.Add(new Rectangle(AIBody[AIBody.Length - 1].X, AIBody[AIBody.Length - 1].Y, width, height)); // add rectangle to list
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

