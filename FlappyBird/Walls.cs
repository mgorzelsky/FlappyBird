using System;
using System.Linq;

namespace FlappyBird
{
    public class Walls
    {
        public int width = 159; // Tracking location of wall, 160 Width
        public int height = 40; // Height of walls, 40 Height
        public int gap = 15;
        public int offset;
        Random rnd;
        int[] wall;  // 0's for WALL 1's for Open Gap

        public Walls()
        {
            rnd = new Random();
            wall = new int[height];
            offset = height - gap;
            WallBuilder();
        }

        void WallBuilder()
        {
            int wallGap = rnd.Next(0, offset);
            for (int i = 0; i < gap; i++)
            {
                wall[wallGap + i] = 1;
            }
        }

    }
}
