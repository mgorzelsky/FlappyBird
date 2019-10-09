using System;
using System.Drawing;
using System.Timers;

namespace FlappyBird
{
    public class Walls
    {
        private Timer timer = new Timer(500);
        private Point position = new Point(0,0);
        private Point priorPosition = new Point(0, 0);
        private int height = 5;
        private int width = 2;
        private int speed = 3;
        private Render render = new Render();



        public Walls()
        {
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;
        }

        public Point getPosition()
        {
            return position;
        }

        public Point getPriorPosition()
        {
            return priorPosition;
        }

        public int getHeight()
        {
            return height;
        }

        public int getWidth()
        {
            return width;
        }

        public void Move()
        {
            priorPosition = position;
            position.X += speed;
            render.drawWalls(this);
        }


        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Move();
        }
    }
}


