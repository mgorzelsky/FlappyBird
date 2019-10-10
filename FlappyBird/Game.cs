using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Drawing;

namespace FlappyBird
{
    public enum CellState { Empty, Bird, Pillar };
    public class Game
    {
        CellState[,] state;
        int score;
        public int HighScore { get; private set; }
        public bool PlayAgain { get; private set; }
        bool gameOver;
        int height;
        int width;

        Bird bird;
        //Walls wall = new Walls();
        Timer wallGenerator = new Timer(5000);
        Timer gameTimer = new Timer(100);
        List<Walls> walls = new List<Walls>();

        public Game()
        {
            bird = new Bird();


            wallGenerator.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            wallGenerator.Enabled = true;
            gameTimer.Elapsed += new ElapsedEventHandler(GameLoop);
            gameTimer.Enabled = true;     
        }

        public void PlayGame(int height, int width)
        {
            this.height = height;
            this.width = width;
            Console.CursorVisible = false;
            ConsoleKey action = ConsoleKey.H;

            while (action != ConsoleKey.Q)
            {
                action = Console.ReadKey().Key;
                if (action == ConsoleKey.UpArrow)
                {
                    bird.Flap();
                    Step();
                    Render.Render();
                }
            }

            gameOver = false;

            do
            {
                Step();
            } while (!gameOver);
        }

        void Step()
        {
            state = new CellState[height, width];
            Point birdPosition = bird.getPosition();
            state[birdPosition.X, birdPosition.Y] = CellState.Bird;
            foreach(var wall in walls)
            {
                int[] wallArray = wall.getWall();
                for (int y = 0; y < wallArray.length; y++)
                {
                    if (wallArray[y] == 0)
                        state[wall.getPosition().X, y] = CellState.Pillar;
                }
            }
            CheckCollision();
        }

        void CheckCollision()
        {
            if (bird.getY() < 1 || bird.getY() > height - 1)
            foreach (var wall in walls)
            {
                if (wall.getPosition().X == bird.getX)
                {
                    if (wall.Wall[bird.getY] == 0)
                        gameOver = true;
                }
            }
        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            walls.Add(new Walls());
        }

        public void GameLoop(Object source, ElapsedEventArgs e)
        {
            Step();
            Render.Render();
        }


    }
}
