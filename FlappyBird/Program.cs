using System;
using System.Timers;

namespace FlappyBird
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey action = ConsoleKey.N;

            Timer gameTimer = new Timer(400);
            gameTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            gameTimer.Enabled = true;

            Console.CursorVisible = false;
            Bird flappy = new Bird(5, 5, 200);
            Wall wall1 = new Wall(90, 0, 40, 100);

            while (action != ConsoleKey.Q)
            {
                flappy.draw();

                action = Console.ReadKey().Key;

                if (action == ConsoleKey.UpArrow) flappy.flap();

            }

        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.Clear();
        }

    }

    //class Bird
    //{
    //    private int positionX;
    //    private int positionY;
    //    private int priorY;
    //    private char icon = '>';
    //    private System.Timers.Timer timer;

    //    public int PositionY {

    //        get
    //        {
    //            return positionY;
    //        }

    //        set
    //        {
    //            positionY = value;
    //        }

    //    }

    //    public Bird(int x, int y, int ms)
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

    //        draw();
    //    }

    //    public void draw()
    //    {
    //        Console.SetCursorPosition(positionX, positionY);
    //        Console.Write(icon);

    //        Console.SetCursorPosition(positionX, priorY);
    //        Console.Write(" ");
    //    }

    //    public void OnTimedEvent(Object source, ElapsedEventArgs e)
    //    {
    //        fall();
    //    } 

    //}

    //class Wall
    //{
    //    private int positionX;
    //    private int positionY;
    //    private int priorX;
    //    private int height;
    //    private int holeHeight = 7;
    //    private char icon = '|';
    //    private System.Timers.Timer timer;

    //    public int PositionX
    //    {

    //        get
    //        {
    //            return positionX;
    //        }

    //        set
    //        {
    //            positionX = value;
    //        }

    //    }

    //    public Wall(int x, int y, int height, int ms)
    //    {
    //        positionX = x;
    //        positionY = y;
    //        this.height = height;
    //        timer = new System.Timers.Timer(ms);
    //        timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
    //        timer.Enabled = true;
    //    }


    //    public void draw()
    //    {

    //        for (int i = 0; i < height; i++)
    //        {
    //            Console.SetCursorPosition(priorX, positionY + i);
    //            Console.Write(" ");
    //        }

    //        for (int i = 0; i < height; i++)
    //        {
    //            Console.SetCursorPosition(positionX, positionY + i);
    //            Console.Write(icon);

    //            if(i == holeHeight)
    //            {
    //                Console.Write(" ");
    //            }
    //        }

    //    }

    //    public void OnTimedEvent(Object source, ElapsedEventArgs e)
    //    {
    //        priorX = PositionX;

    //        PositionX -= 1;

    //        draw();
    //    }

    //}
}
