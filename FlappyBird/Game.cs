using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBird
{
    public enum CellState { Empty, Bird, Pillar };
    class Game
    {
        CellState[,] state;
        public void PlayGame(int height, int width)
        {
            state = new CellState[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine(state[i,j]);
                }
            }
        }
    }
}
