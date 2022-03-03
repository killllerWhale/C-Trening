using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Triangle
    {
        private float sideA; // сторона А
        private float sideB; // сторона B
        private float sideC; // сторона C

        public Triangle(double sideA, double sideB, double sideC)
        {
            // конструктор с параметрами 

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public string Show()
        {
            return ("\nТреугольник: \nСторона А: " + sideA + "\nСторона B: " + sideA + "\nСторона С: " + sideA);

        }

        public int Pyrimeter()
        {
            return sideA+sideB+sideC;
        }

        public int Square()
        {
            return ;
        }

    }
}
