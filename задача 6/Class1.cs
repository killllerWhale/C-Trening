uusing System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Число положительное");
            }
            else if (n == 0)
            {
                Console.WriteLine("Число равно нулю");
            }
            else
            {
                Console.WriteLine("Число отрицательное");
            }
        }
    }
}