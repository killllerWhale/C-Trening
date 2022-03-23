using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Triangle
    {
        public Double a;
        public Double b;
        public Double c;

        public Triangle(Double a, Double b, Double c)
        {
            if ((a + b > c) & (b + c > a) & (a + c) > b)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new InvalidOperationException("Треугольник не существкет");
            }

            
        }

        public string Show()
        {
            return ("\nТреугольник: \nСторона А: " + a + "\nСторона B: " + b + "\nСторона С: " + c);

        }

        public Double Pyrimeter()
        {
            return a+b+c;
        }

        public Double Square()
        {
            return Math.Sqrt(Pyrimeter()*(Pyrimeter()-a) * (Pyrimeter() - b) * (Pyrimeter() - c));
        }

    }
}
