using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string Show()
        {
            return ("\nКоординаты : \nТочка Х: " + x + "\nТочка Y: " + y);

        }

        public double ToZero()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public void Move(int a, int b)
        {
            x += a;
            y += b;
        }

        public int Scalar
        {
            set
            {
                x = x * value;
                y = y * value;
            }

        }
    }
}
