using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                int coast = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        coast++;
                    }
                }
                string t = String.Concat(Enumerable.Repeat("+", coast));
                Console.WriteLine($"{i}{t}");
            }
        }
    }
}