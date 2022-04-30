using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class ArithmeticProgression : Progression
    {
        private double a;
        private double b;

        public ArithmeticProgression(double a, double b)
        {
            this.a = a; this.b = b;
        }
        public override double GetElement(int k)
        {
            return (a + (k - 1)*b);
        }
    }
}
