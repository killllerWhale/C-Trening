using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int p = Convert.ToInt32(Console.ReadLine());
            int i = p;
            int fact = 1;
            do
            {
                fact *= i;
                --i;
            }
            while (i > 0);
            Console.WriteLine($"{p}! = {fact}");
            Console.ReadLine();
        }
    }
}