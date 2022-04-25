using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPlayerX = 2;
            int playerPlayerY = 5;

            Render render = new Render();

            render.ShowPlaer(playerPlayerX, playerPlayerY);

            Console.ReadKey();
        }
    }

    class Player
    {
        private int maxLimitX = 50;
        private int minLimitX = 0;
        private int maxLimitY = 50;
        private int minLimitY = 0;
        public int PositionPlayerX { get; private set; }
        public int PositionPlayerY { get; private set; }

        

       public Player(int positionPlaerX, int positionPlaerY)
        {
            if(positionPlaerX>minLimitX&positionPlaerX<maxLimitX)
            {
                PositionPlayerX = positionPlaerX;
            }
            if (positionPlaerY > minLimitY & positionPlaerY < maxLimitY) 
            {
                PositionPlayerY = positionPlaerY;
            }
        }
    }

    class Render
    {
        public void ShowPlaer(int positionPlaer, int positionPlaerY, char plaer = '@')
        {
            Player position = new Player(positionPlaer,positionPlaerY);

            Console.SetCursorPosition(position.PositionPlayerX, position.PositionPlayerY);
            Console.Write(plaer);
        }
    }
}
