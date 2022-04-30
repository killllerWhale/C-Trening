using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circle : Shape
    {
        private double ragius;
        public Circle(double ragius)
        {
            this.ragius = ragius;
        }
        public override double Area()
        {
            return ragius * ragius;
        }
    }
}
