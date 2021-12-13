using System;

class Program

{
    static void Main(string[] args)
    {
        string rus = Convert.ToString(Console.ReadLine());
        int counter = 0;

        for (int i = 0; i < rus.Length; i++)
        {
            if (rus[i] == 'а')
            {
                counter++;
            }
        }
        Console.WriteLine(rus.Replace("а", "о"));
        Console.WriteLine("Кол-во замен: " + counter.ToString());
        Console.WriteLine("Символов в строке: " + (rus.Length).ToString());
    }
}