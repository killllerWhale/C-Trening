using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (n > 1)
            {
                n = n / 2;
                i++;
            }
            Console.WriteLine("Степень: " + i.ToString());
        }
    }
}