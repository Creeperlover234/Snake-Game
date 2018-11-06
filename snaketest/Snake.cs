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
    class Snake
    {
        public Rectangle[] Body; // body of snake, needs to be array so we can add to it.
        int speed = 20; // default speed of snake
        public enum Direction {Up,Down,Left,Right,NONE};
        public Direction direction;
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
        
        public Snake()
        { 
            Body = new Rectangle[1];
            Body[0] = new Rectangle(x, y, width, height); // for drawing snake
        }

        public void UpdateBody()
        {
            for (int i = Body.Length - 1; i > 0; i--) //odd flex but ok
                Body[i] = Body[i - 1];
        }

        public void Draw(Graphics g)
        {
            for (int i = Body.Length - 1; i > 0; i--)
                g.FillEllipse(bodyColor, Body[i]); // MOAR CIRCLEZZZZZ

            g.FillEllipse(headColor, Body[0]); // CIRCLES

        }

        public void Grow() // creates new rectangle to snake array, in essence, the snake 'grows'
        {
            List<Rectangle> bodyAdd = Body.ToList(); // we do this to make life easier ;)
            bodyAdd.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length - 1].Y, width, height)); // add rectangle to list
            Body = bodyAdd.ToArray();
        }

        public void Move()
        {
            UpdateBody();
            switch(direction)
            {
                case Direction.Up:
                    Body[0].Y -= speed;
                    break;
                case Direction.Down:
                    Body[0].Y += speed;
                    break;
                case Direction.Left:
                    Body[0].X -= speed;
                    break;
                case Direction.Right:
                    Body[0].X += speed;
                    break;
                case Direction.NONE:
                    Body[0].X += 0;
                    Body[0].Y += 0;
                    break;
                default:
                    break;
            }
        }

    }
}