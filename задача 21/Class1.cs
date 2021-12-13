using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i += 2)
            {
                if (array[i] > array[i + 1] + array[i - 1])
                {
                    count += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
        }
    }
}