using System;

class Program

{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        ChangeDigits(ref x);
    }
    static void ChangeDigits(ref int n)
    {
        int temp = n / 10;
        n = n % 10;
        n = (n * 10) + temp;
    }
}