using System;

namespace MyClassSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Point pointOne = new Point();
            pointOne.Show();
            Point pointTwo = new Point(12, 13);
            pointTwo.Show();
            Segment sigment = new Segment(pointOne, pointTwo);
            sigment.Show();

            double d = sigment.Length();
            Console.WriteLine("Длина отрезка: {0}", d);
            
            
        }
    }
}
