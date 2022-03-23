using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book b2 = new Book("Толстой Л.Н.", "Война и мир","Наука и жизнь", 1234, 2013);
            //Console.WriteLine(b2.Show());
            //Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            //Console.WriteLine(b3.Show());
            //Triangle trangle = new Triangle(5, 1, 7);
            //Triangle trangle = new Triangle(5, 6, 7);
            //Console.WriteLine(trangle.Pyrimeter());
            //Console.WriteLine(trangle.Square());
            MyStr mystr = new MyStr("ПриВЕТ,. мир");
            Console.WriteLine(mystr.Length);
            mystr.Prop();
            Console.WriteLine(mystr.Line);
            mystr.del();
            Console.WriteLine(mystr.Line);
            

        }
    }
}
