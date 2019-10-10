using System;
using System.Collections.Generic;
using System.Text;
/*
namespace FlappyBird
{

    class Game
    {
        CellState[,] state;
        public void PlayGame(int height, int width)
        {
            state = new CellState[height, width];

            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        Console.Write(state[i,j]);
            //    }
            //}
        }
    }
}
*/
using System.Timers;

namespace FlappyBird
{
    public enum CellState { Empty, Bird, Pillar };
    public class Game
    {
        Bird bird = new Bird();
        //Walls wall = new Walls();
        Timer wallGenerator = new Timer(5000);
        Timer gameTimer = new Timer(50000);
        List<Walls> walls = new List<Walls>();

        public Game()
        {
            wallGenerator.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            wallGenerator.Enabled = true;

       

            Console.CursorVisible = false;
            ConsoleKey action = ConsoleKey.H;

            while (action != ConsoleKey.Q)
            {
                action = Console.ReadKey().Key;
                if (action == ConsoleKey.UpArrow) bird.Flap();
            }
        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            walls.Add(new Walls());
        }



    }
}
