using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, -6, 7, 8, 9, 10, -11, 12, 13, -4, 15, 16, -7, 18, 19, 20 };
            int[] b = { 21, 22, -23, 24, 25, -26, 27, -28, 29, 30, -31, 32, 33, 34, 35 };
            int[] c = { 31, -32, 33, -34, 35, 36, 37, -38, 39, 40 };

            Console.Write(summa(a, b, c));

        }
        static double summa(int[] a, int[] b, int[] c)
        {

            int summaA = 0;
            int summaB = 0;
            int summaC = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    summaA += a[i];
                }
            }
            for (int ii = 0; ii < b.Length; ii++)
            {
                if (b[ii] > 0)
                {
                    summaB += a[ii];
                }
            }
            for (int iii = 0; iii < c.Length; iii++)
            {
                if (c[iii] > 0)
                {
                    summaA += c[iii];
                }
            }
            double result = (summaA + summaB + summaC) / 2;
            return result;
        }




    }
}
