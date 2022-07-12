using System;
using System.Collections.Generic;
using System.Text;

namespace SNAKE_.Class
{
    public class Food
    {
        public int xCoordinate = 5;
        public int yCoordinate = 5;
        public string skin = "O";

        Random rnd = new Random();

        public void Generation(int Width, int Height)
        {
            xCoordinate = rnd.Next(2,Width-2);
            yCoordinate = rnd.Next(2, Height - 2);
        }
    }
}
