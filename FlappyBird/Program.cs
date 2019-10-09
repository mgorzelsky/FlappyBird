using System;

namespace FlappyBird
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 160;
            int height = 40;
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(width, height);
            Console.SetWindowSize(width, height);
        }
    }
}