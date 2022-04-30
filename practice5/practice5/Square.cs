using System;
using System.Collections.Generic;
using System.Text;

namespace practice4
{
    class Square : Shape
    {
        public double а;
        public Square(double а)
        {
            this.а = а;
        }
        public double Area()
        {
            return а * а;
        }
    }
}
