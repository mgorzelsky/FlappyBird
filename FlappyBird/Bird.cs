using System;
using System.Timers;

namespace FlappyBird
{
    public class Bird
    {
        private int positionX;
        private int positionY;
        private int priorY;
        private char icon = '>';
        private System.Timers.Timer timer;

        public int PositionY
        {

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

            draw();
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
}
