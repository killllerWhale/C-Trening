using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Rectangle
    {

        private int x;
        private int y;
        private bool a_square = false;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public bool A_square
        {
            get
            {
                if (x == y)
                {
                    return true;
                }
                else { return a_square; }
            }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string Show()
        {
            return ("\nПрямоугольник: \nСторона А: " + x + "\nСторона B: " + y);

        }

        public int Pyrimeter()
        {
            return (x+y)*2;
        }

        public int Square()
        {
            return x * y;
        }
    }
}
