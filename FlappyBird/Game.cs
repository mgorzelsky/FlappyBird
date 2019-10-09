using System;
using System.Timers;

namespace FlappyBird
{
    public class Game
    {
        Bird bird = new Bird();
        //Render render = new Render();

        public Game()
        {
            Console.CursorVisible = false;
            ConsoleKey action = ConsoleKey.H;

            while (action != ConsoleKey.Q)
            {
                action = Console.ReadKey().Key;
                if (action == ConsoleKey.UpArrow) bird.Flap();
            }
        }

        

    }
}