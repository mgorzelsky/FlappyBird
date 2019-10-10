using System;

using System.Drawing;
using System.Timers;

using System.Linq;

namespace FlappyBird
{
    public class Walls
    {

        private Timer timer = new Timer(500);
        private Point position = new Point(159, 0);
        private Point priorPosition = new Point(159, 0);
        private int height = 40;
        private int width = 2;
        public int gap = 15;
        public int offset;
        Random rnd;
        private int speed = 3;
        private Render render = new Render();
        private int[] wall;



        public Walls()
        {
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Enabled = true;
            rnd = new Random();
            wall = new int[height];
            offset = height - gap;
            WallBuilder();

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
            position.X -= speed;
            render.drawWalls(this);
        }

        public int[] getWall()
        {
            return wall;
        }

        void WallBuilder()
        {
            int wallGap = rnd.Next(0, offset);
            for (int i = 0; i < gap; i++)
            {
                wall[wallGap + i] = 1;
            }
        }


        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Move();
        }
    }
}




