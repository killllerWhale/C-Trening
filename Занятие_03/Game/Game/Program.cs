using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Gamer gamerOne = new Gamer("Василий");

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Выпало количество очков " + gamerOne.SeansGame() + " для игрокапо имени " + gamerOne.ToString());
            }
        }
    }
}
