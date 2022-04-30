using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Square : Shape
    {
        private double a;
        public Square(double a) => this.a = a;
        public override double Area()
        {
            return a * a;
        }
    }
}
