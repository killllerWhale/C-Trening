using System;
using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        for (int i = 120; i <= 140; i++)
        {
            int deliteli = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    deliteli += 1;
                }
            }
            Console.WriteLine($"Кол-во делителей числа {i} равно " + deliteli.ToString());
        }
    }
}