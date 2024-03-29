﻿using System;
using System.Drawing;
using System.Threading;

namespace FlappyBird
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 160;
            int height = 40;
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(width, height + 1);
            Console.SetWindowSize(width, height + 1);

            Game game = new Game();
            Console.WriteLine("Welcome to flappy bird in the terminal.");
            Thread.Sleep(2000);

            do
            {
                game.PlayGame(height, width);
            } while (game.PlayAgain);

            //Game game = new Game();
            //Console.WriteLine("Welcome to flappy bird in the terminal.");
            //do
            //{
            //    game.PlayGame(height, width);
            //} while (playAgain);

            //if (game.HighScore < 5)
            //    Console.Write($"Booooooooo! Your high score was {game.HighScore}");
            //else if (game.HighScore >= 5 && game.HighScore < 15)
            //    Console.Write($"Nice try! Your high score was {game.HighScore}");
            //else if (game.HighScore >= 15 && game.HighScore < 30)
            //    Console.Write($"Wow! Thats pretty good! Your high score was {game.HighScore}");
            //else
            //    Console.Write($"You are really good at this! Your high score was {game.HighScore}");
        }
    }
}