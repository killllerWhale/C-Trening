using System;
using System.Collections.Generic;
using System.Text;

namespace control_test_3
{
    class City : Place
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
