using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

//namespace FlappyBird
//{

//    class Game
//    {
//        CellState[,] state;
//        public void PlayGame(int height, int width)
//        {
//            state = new CellState[height, width];

//            for (int i = 0; i < height; i++)
//            {
//                for (int j = 0; j < width; j++)
//                {
//                    Console.Write(state[i, j]);
//                }
//            }
//        }
//    }
//}



namespace FlappyBird
{
    public enum CellState { Empty, Bird, Pillar };
    public class Game
    {
        Bird bird = new Bird(20,5);
        //Walls wall = new Walls();
        Timer wallGenerator = new Timer(5000);
        Timer gameTimer = new Timer(50000);
        List<Walls> walls = new List<Walls>();
        CellState[,] state;
        int height;
        int width;



        public Game(int height, int width)
        {

            state = new CellState[height, width];
            this.height = height;
            this.width = width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(state[i, j]);
                }
            }

            wallGenerator.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            wallGenerator.Enabled = true;

       
        }

        public void Play()
            {

                Render renderer = new Render(state, height, width);

                Console.CursorVisible = false;
                ConsoleKey action = ConsoleKey.H;

                while (action != ConsoleKey.Q)
                {
                    action = Console.ReadKey().Key;
                    if (action == ConsoleKey.UpArrow) bird.Flap();
                    state[bird.getX(), bird.getY()] = CellState.Bird;
                    renderer.Display(state, height, width);

                }
            }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            walls.Add(new Walls());
        }



    }
}
