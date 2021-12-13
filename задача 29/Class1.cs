using System;

namespace LessonTwoWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1: Найти сумму первых N членов арифметической прогрессии с использованием цикла for.

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма первых {0} членов арифметической прогрессии равна {1}", n, sum);

            //Задание 2: Вычислить факториал числа p(при p > 0), используя цикл do while.

            Console.Write("p = ");
            int p = Convert.ToInt32(Console.ReadLine());
            int i = p;
            int factorial = 1;
            do
            {
                factorial = factorial * i;
                --i;
            }
            while (i > 1);

            Console.WriteLine($"{p}!= {factorial}");

            //Задание 3: Посчитать количество и сумму парных чисел в диапазоне от 1 до N.

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            sum = 0;
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    s++;
                    sum += n;
                }

                n -= 1;
            }
            Console.WriteLine("колличество пар: ", s, "сумма пар: ", sum);


            //Задание 5: Используя вложенные циклы, вывести таблицы умножения от второй до шестой.

            for (int i = 2; i < 7; i++)
            {
                Console.WriteLine($"Таблица умножения на: " + i);
                for (int x = 2; x < 10; x++)
                {
                    int d = i * x;
                    Console.WriteLine(d);
                }
                Console.WriteLine();
            }
        }
    }