using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPositionX = 2;
            int playerPositionY = 5;
            char player = '@';

            Render render = new Render();

            render.ShowPlayer(playerPositionX, playerPositionY,player);

            Console.ReadKey();
        }
    }

    class Player
    {

        private int maxWidth = 50;
        private int minWidth = 0;
        private int maxHeight = 50;
        private int minHeight = 0;

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

       public Player(int positionPlaerX, int positionPlaerY)
        {
            if (positionPlaerX > minWidth & positionPlaerX < maxWidth) 
            {
                PositionX = positionPlaerX;
            }
            if (positionPlaerY > minHeight & positionPlaerY < maxHeight) 
            {
                PositionY = positionPlaerY;
            }
        }
    }

    class Render
    {
        public void ShowPlayer(int positionX, int positionY, char player = '@')
        {
            Player position = new Player(positionX,positionY);

            Console.SetCursorPosition(position.PositionX, position.PositionY);
            Console.Write(player);
        }
    }
}
