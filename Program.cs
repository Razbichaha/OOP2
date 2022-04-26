using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPositionX = 2;
            int playerPositionY = 5;
            char playerSkin = '@';

            Player player = new Player(playerPositionX,playerPositionY);

            player.Show(playerSkin);

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

        public  void Show(char player)
        {
            Render render = new Render();

            render.ShowPlayer(PositionX, PositionY,player);
        }
    }

    public class Render
    {
        public void ShowPlayer(int positionX, int positionY, char player = '@')
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(player);
        }
    }
}
