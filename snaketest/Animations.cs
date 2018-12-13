using System;

namespace snaketest
{
    class Animations
    {

        /*
         * 
         * Probably one of the most ineffecient ways to move the animations to a separate class.
         * I think PerformDebugAnimation is fine. But, PerformFullScreenAnimation is a mess.
         * Anyways, this literally is just an animation class. We call these functions when we want to
         * perform a specific animation. So, when the player hits f4(fullscreen) we want to call 
         * PerformFullscreenAnimation, etc.
         * 
        */

        public int GameboardWidth = 0;
        public int formWidth = 0;
        public int gameOvWidth = 0;

        public int PerformDebugAnimation(int Width, bool start)
        {

            if (start)
            {
                //slide to right
                if (Width < 884)
                    Width += 10;

            }else if(!start)
            {
                //now take it back now y'all
                if (Width > 784)
                    Width -= 10;
            }

            return Width;
        }

        public void PerformFullscreenAnimation(int FormWidth, int GameBoardWidth, int GameovLabel, bool start)
        {
            //formWidth is the Width of the actualy application
            //GameboardWidth is the width of the picturebox, where the snake game is played
            //gameovlabel is the width of the Game Over label

            FormWidth = getFW();
            GameBoardWidth = getGBW();
            GameovLabel = getGmovLabel();

            if (start)
            {
                if (formWidth > 554)
                    formWidth -= 10;

                if (GameboardWidth > 8)
                    GameboardWidth--;

                if (gameOvWidth > 9)
                    gameOvWidth--;
            }
            else
            {
                if (formWidth < 784)
                    formWidth += 10;

                if (GameboardWidth < 12)
                    GameboardWidth += 1;

                if (gameOvWidth < 13)
                    gameOvWidth++;
            }

        }

        public int getGBW()
        {
            return GameboardWidth;
        }

        public int getFW()
        {
            return formWidth;
        }

        public int getGmovLabel()
        {
            return gameOvWidth;
        }

        public int GameBoardWidth(int gameBoard)
        {
            return GameboardWidth = gameBoard;
        }

        public int FormWidth(int FW)
        {
            return formWidth = FW;
        }

        public int GameOvLabel(int gmovLabel)
        {
            return gameOvWidth = gmovLabel;
        }

    }
}
