using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сумму покупки: ");

        float buyPrice = float.Parse(Console.ReadLine());

        float sale = 0;

        if (buyPrice >= 1000)
        {
            sale = 0.05f;
        }
        else if (buyPrice >= 500)
        {
            sale = 0.03f;
        }

        buyPrice -= buyPrice * sale;

        Console.WriteLine($"Сумма покупки составила {buyPrice} денежных едениц со скидкой {sale}%");
    }
}
