using System;
using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        int maxi = -100000000;
        int mini = 100000000;
        MinmaxSeq(ref mini, maxi);
    }
    static void MinmaxSeq(ref int minim, int maxim)
    {
        int x = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>() { x };
        while (x != 0)
        {
            x = Convert.ToInt32(Console.ReadLine());
            numbers.Add(x);
        }
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > maxim)
            {
                maxim = numbers[i];
            }
            else if (numbers[i] < minim)
            {
                minim = numbers[i];
            }
        }
    }
}
