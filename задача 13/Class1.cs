using System;
using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 300; i++)
        {
            int deliteli = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    deliteli += 1;
                }
            }
            if (deliteli == 5)
            {
                Console.WriteLine($"Кол-во делителей числа {i} равно " + deliteli.ToString());
            }
        }
    }
}