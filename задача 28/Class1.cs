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
            for (int i = 1; i <= 300; i++)
            {
                int coast = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        coast++;
                    }
                }
                if (coast == 5)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}