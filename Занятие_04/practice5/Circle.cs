using System;
using System.Collections.Generic;
using System.Text;

namespace practice4
{
    class Circle : Shape
    {
        public double r;
        private double pi = 3.141592;
        public Circle(double r)
        {
            this.r = r;
        }
        public double Area()
        {
            return pi * (r * r);
        }
    }
}
