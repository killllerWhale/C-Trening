using System;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine(Perimeter(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
    }
    static int Perimeter(int a, int b, int c)
    {
        int per = a + b + c;
        return per;
    }
}
