﻿using System;
/*
using System.Drawing;
using System.Timers;
*/
using System.Linq;

namespace FlappyBird
{
    public class Walls
    {
/*
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


*/
        public int width = 159; // Tracking location of wall, 160 Width
        public int height = 40; // Height of walls, 40 Height
        public int gap = 15;
        public int offset;
        Random rnd;
        int[] wall;  // 0's for WALL 1's for Open Gap

        public Walls()
        {
            rnd = new Random();
            wall = new int[height];
            offset = height - gap;
            WallBuilder();
        }

        void WallBuilder()
        {
            int wallGap = rnd.Next(0, offset);
            for (int i = 0; i < gap; i++)
            {
                wall[wallGap + i] = 1;
            }
        }

    }
}
