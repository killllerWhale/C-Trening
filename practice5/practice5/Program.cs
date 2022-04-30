using practice2;
using practice4;
using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы",2014, 1235, true);
            mag1.Show();
            mag1.IfSubs = true;
            mag1.Subs();

            Book b2 = new Book("Пергун", "Мир во всем мире","Наука и жизнь", 100, 2013);
            Book b1 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2018);
            Book b3 = new Book("Николенко", "Война!", "Наука и жизнь", 1222, 2023);

            Item[] itmas = new Item[3];
            itmas[0] = b1;
            itmas[1] = b2;
            itmas[2] = b3;
            Array.Sort(itmas);
            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach (Item x in itmas)
            {
                x.Show();
            }
            ArithmeticProgression a = new ArithmeticProgression(1, 8);
            Console.WriteLine(a.SumElement(4));
            GeometricProgression a1 = new GeometricProgression(1, 8);
            Console.WriteLine(a1.SumElement(4));
            Square a = new Square(8);
            Console.WriteLine(a.Area());
            Circle a1 = new Circle(8);
            Console.WriteLine(a1.Area());

        }
    }
}
