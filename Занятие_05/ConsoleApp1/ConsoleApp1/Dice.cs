using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void EventHandler();

    internal class Dice
    {
        private Random r;

        public Dice()
        {
            r = new Random();
        }

        public event EventHandler max;

        public int Roll()
        {
            int res = r.Next(6) + 1;
            if (res == 6)
            {
                max();

            }

            return res;
        }
    }
}
