using System;

namespace snaketest
{
    class RandomXY
    {
        double x;
        double randx;
        double y;
        double randy;

        // we want to have to have the main class specify random cus then that eliminates the possibility
        // of the X or Y coord being the exact same since we aren't initializing rand every time we want to
        // gen a new XY coord.

        public double RandX(Random rand) // we generate a random X coord.
        {
            randx = rand.Next(20, 500);

            x = Math.Round(Math.Ceiling((float)randx / 20) * 20, MidpointRounding.ToEven);

            return x;
        }

        public double RandY(Random rand) // gen rand y coord
        {
            randy = rand.Next(20, 500);

            y = Math.Round(Math.Ceiling((float)randy / 20) * 20, MidpointRounding.ToEven);

            return y;
        }

    }
}
