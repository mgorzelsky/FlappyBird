using System;
using System.Timers;

namespace FlappyBird
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey action = ConsoleKey.N;
            
            Console.CursorVisible = false;
            Bird flappy = new Bird(5, 5, 500);

            while (action != ConsoleKey.Q)
            {
                flappy.draw();

                action = Console.ReadKey().Key;

                if (action == ConsoleKey.UpArrow) flappy.flap();

            }

        }

    }

    class Bird
    {
        private int positionX;
        private int positionY;
        private int priorY;
        private char icon = '>';
        private System.Timers.Timer timer;

        public int PositionY {

            get
            {
                return positionY;
            }

            set
            {
                positionY = value;
            }

        }

        public Bird(int x, int y, int ms)
        {
            positionX = x;
            positionY = y;
            timer = new System.Timers.Timer(ms);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;
        }

        public void flap()
        {
            priorY = PositionY;

            PositionY -= 3;

        }

        public void fall()
        {
            priorY = positionY;
            PositionY += 1;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(icon);
            Console.SetCursorPosition(positionX, priorY);
            Console.Write(" ");

        }

        public void draw()
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(icon);

            Console.SetCursorPosition(positionX, priorY);
            Console.Write(" ");
        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            fall();
        } 

    }

    //class Wall
    //{
    //    private int positionX;
    //    private int positionY;
    //    private int priorX;
    //    private int height;
    //    private int holeHeight;
    //    private char icon = '|';
    //    private System.Timers.Timer timer;

    //    public int PositionY
    //    {

    //        get
    //        {
    //            return positionY;
    //        }

    //        set
    //        {
    //            positionY = value;
    //        }

    //    }

    //    public Wall(int x, int y, int ms)
    //    {
    //        positionX = x;
    //        positionY = y;
    //        timer = new System.Timers.Timer(ms);
    //        timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
    //        timer.Enabled = true;
    //    }

    //    public void flap()
    //    {
    //        priorY = PositionY;

    //        PositionY -= 3;

    //    }

    //    public void fall()
    //    {
    //        priorY = positionY;
    //        PositionY += 1;
    //        Console.SetCursorPosition(positionX, positionY);
    //        Console.Write(icon);
    //        Console.SetCursorPosition(positionX, priorY);
    //        Console.Write(" ");

    //    }

    //    public void draw()
    //    {

    //        for(int i = 0; i < height; i++)
    //        {
    //            Console.SetCursorPosition(positionX, positionY);
    //            Console.Write(icon);
    //        }


    //        Console.SetCursorPosition(positionX, priorX);
    //        Console.Write(" ");
    //    }

    //    public void OnTimedEvent(Object source, ElapsedEventArgs e)
    //    {
    //        fall();
    //    }

    //    public string toString()
    //    {
    //        Console.SetCursorPosition()
    //    }

    //}
}
