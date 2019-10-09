using System;
using System.Drawing;
using System.Timers;

namespace FlappyBird
{
    public class Bird
    {
        private int gravity = 1;
        //private int size = 2;
        private Point position = new Point(20,5);
        private Timer timer = new Timer(500);
        private Render render = new Render();
        public int priorY = 5;

        public Bird()
        {
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;
        }

        public Point getPosition()
        {
            return position;
        }

        public int getX()
        {
            return position.X;
        }

        public int getY()
        {
            return position.Y;
        }

        public void setX(int x)
        {
            position.X = x;
        }

        public void setY(int y)
        {
            position.Y = y;
        }

        public void Flap()
        {
            priorY = position.Y;
            position.Y -= 3;
            render.drawBird(this);
        }

        public void Drop()
        {
            priorY = position.Y;
            position.Y += gravity;
            render.drawBird(this);

        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Drop();
        }


    }
}
