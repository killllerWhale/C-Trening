using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите русскоязычную строку:\t");
            string s = Console.ReadLine();
            Console.Write("Измененная строка: ");
            Console.WriteLine(new string(s.Select(x => Char.IsUpper(x) ? Char.ToLower(x) : x).ToArray()));
        }
    }
}