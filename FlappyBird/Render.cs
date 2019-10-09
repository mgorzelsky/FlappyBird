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
    }
}
