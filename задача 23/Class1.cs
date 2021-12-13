using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало интервала");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец интервала");
            int b = Convert.ToInt32(Console.ReadLine());
            int sumi = 0;
            if (b >= a)
            {
                for (int i = a; i <= b; i++)
                {
                    sumi += i;
                }
                Console.WriteLine("Сумма: " + sumi.ToString());
            }
            else
            {
                Console.WriteLine("Ошибка: Начало диапозона больше конца");
            }
        }
    }
}