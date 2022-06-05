using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Place
    {
        String name { get; }
        String location { get; set; }
        double square { get; }
        int population;

        public Place(String nam, String loc, double squ, int popul)
        {
            this.name = nam;
            this.location = loc;
            this.square = squ;
            this.population = popul;

        }

        public int Population
        {
            get { return population; }

            set { }

        }

        public void population_people(int pepl, string mean)
        {
            if (mean == "-")
            {
                population = population - pepl;
            }
            else
            {
                population = population + pepl;
            }
        }
    }
}
