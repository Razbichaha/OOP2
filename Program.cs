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

            Render render = new Render();

            render.ShowPlayer(player.PositionX, player.PositionY,playerSkin);

            Console.ReadKey();
        }
    }

    class Player
    {

        private int _maxWidth = 50;
        private int _minWidth = 0;
        private int _maxHeight = 50;
        private int _minHeight = 0;

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

       public Player(int positionPlaerX, int positionPlaerY)
        {
            if (positionPlaerX > _minWidth & positionPlaerX < _maxWidth) 
            {
                PositionX = positionPlaerX;
            }
            if (positionPlaerY > _minHeight & positionPlaerY < _maxHeight) 
            {
                PositionY = positionPlaerY;
            }
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
