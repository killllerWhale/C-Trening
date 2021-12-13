using System;

namespace CSharp_lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму покупки");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 500 && n < 1000)
            {
                Console.WriteLine("Стоимость вашей покупки с учетом скидки " + (n - (n * 0.03)).ToString());
            }
            else if (n > 1000)
            {
                Console.WriteLine("Стоимость вашей покупки с учетом скидки " + (n - (n * 0.05)).ToString());
            }
        }
    }
}