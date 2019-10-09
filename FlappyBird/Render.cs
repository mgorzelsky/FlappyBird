using System;
namespace FlappyBird
{
    public class Render
    {


        public Render()
        {
        }

        public void drawBird(Bird bird)
        {
            Console.SetCursorPosition(bird.getX(), bird.getY());
            Console.Write("*");
            Console.SetCursorPosition(bird.getX(), bird.priorY);
            Console.Write(" ");
            
        }

        public void drawWalls(Walls wall)
        {
            int x = wall.getPosition().X;
            int y = wall.getPosition().Y;
            int priorX = wall.getPriorPosition().X;
            int priorY = wall.getPriorPosition().Y;
            int height = wall.getHeight();
            int width = wall.getWidth();

            for(int i = 0; i < height;i++)
            {
                Console.SetCursorPosition(x, y++);
                Console.Write("<");
                Console.SetCursorPosition(priorX, priorY++);
                Console.Write(" ");

            }

            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(x++, y);
                Console.Write("<");
                Console.SetCursorPosition(priorX++, priorY);
                Console.Write(" ");

            }

            for (int i = 0; i <= height; i++)
            {
                Console.SetCursorPosition(x, y--);
                Console.Write("<");
                Console.SetCursorPosition(priorX, priorY--);
                Console.Write(" ");

            }



        }
    }
}
