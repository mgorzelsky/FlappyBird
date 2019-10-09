using System;
using System.Timers;

namespace FlappyBird
{
    public class Wall
    {
        private int positionX;
        private int positionY;
        private int priorX;
        private int height;
        private int holeHeight = 7;
        private char icon = '|';
        private System.Timers.Timer timer;

        public int PositionX
        {

            get
            {
                return positionX;
            }

            set
            {
                positionX = value;
            }

        }

        public Wall(int x, int y, int height, int ms)
        {
            positionX = x;
            positionY = y;
            this.height = height;
            timer = new System.Timers.Timer(ms);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;
        }


        public void draw()
        {

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(priorX, positionY + i);
                Console.Write(" ");
            }

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(positionX, positionY + i);
                Console.Write(icon);

                if (i == holeHeight)
                {
                    Console.Write(" ");
                }
            }

        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            priorX = PositionX;

            PositionX -= 1;

            draw();
        }

    }
}
