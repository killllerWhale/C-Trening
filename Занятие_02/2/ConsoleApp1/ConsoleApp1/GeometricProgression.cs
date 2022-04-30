using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GeometricProgression : Progression
    {
        private double a;
        private double b;

        public GeometricProgression(double a, double b)
        {
            this.a = a; this.b = b;
        }

        public override double GetElement(int k)
        {
            return a * Math.Pow(b, k - 1);
        }
    }
}
