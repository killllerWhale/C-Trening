using System;
using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        int d = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= d; i++)
        {
            string deliteli = $"{i} ";
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    deliteli += "+";
                }
            }
            Console.WriteLine(deliteli);
        }
    }
}
