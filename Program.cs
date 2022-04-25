using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerX = 2;
            int playerY = 5;

            Render render = new Render();

            render.showPlaer(playerX, playerY);

            Console.ReadKey();
        }
    }

    class Plaer
    {
        public int positionX { get; private set; }
        public int positionY { get; private set; }

        private int maxLimitX = 50;
        private int minLimitX = 0;
        private int maxLimitY = 50;
        private int minLimitY = 0;

       public Plaer(int x, int y)
        {
            if(x>minLimitX&x<maxLimitX)
            {
                positionX = x;
            }
            if (y > minLimitY & y < maxLimitY) 
            {
                positionY = y;
            }
        }
    }

    class Render
    {
        public void showPlaer(int X, int Y, char plaer = '@')
        {
            Plaer position = new Plaer(X,Y);

            Console.SetCursorPosition(position.positionX, position.positionY);
            Console.Write(plaer);
        }
    }
}
