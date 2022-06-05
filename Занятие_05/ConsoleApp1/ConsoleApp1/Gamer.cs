using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Gamer
    {
        string name;
        Dice seans;

        public Gamer(string name)
        {
            this.name = name;
            seans = new Dice();
            seans.max += new EventHandler(Metodobrabotchik);
        }

        public int SeansGame()
        {
            return seans.Roll();
        }

        public override string ToString()
        {
            return name;
        }

        public static void Metodobrabotchik()

        {

            Console.WriteLine("Бинго! 6 очков!");

        }



    }
}
