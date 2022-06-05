using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class City : Place
    {
        public City(String nam, String loc, double squ, int popul) : base(nam, loc, squ, popul)
        {
        }

        public bool Check_megapolice()
        {
            if (Population > 4000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
