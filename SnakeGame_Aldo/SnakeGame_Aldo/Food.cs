using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SnakeGame_Aldo
{
    public class Food
    {
        public Rectangle foodRec;
        private SolidBrush brush;
        private int x, y, width, height;

        public Food(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;

            brush = new SolidBrush(Color.Black);

            width = 10;
            height = 10;

            foodRec = new Rectangle(x, y, width, height);
        }

        public void foodLocation(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;
        }

        public void drawFood(Graphics paper)
        {

        }
    }
}
