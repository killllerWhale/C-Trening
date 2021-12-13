using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (1 <= a && a <= 3)
            {
                count++;
            }
            if (1 <= b && b <= 3)
            {
                count++;
            }
            if (1 <= c && c <= 3)
            {
                count++;
            }
            Console.WriteLine("Количество чисел принадлежащих отрезку от 1 до 3 равно " + (count).ToString());
        }
    }
}