using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Square : Shape
    {
        private double a;
        public Circle(double a)
        {
            this.a = a;
        }
        public override double Area()
        {
            return a * a;
        }
    }
}
