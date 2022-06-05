using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void EventHandler();

    internal class Region : Place
    {
        List<Object> cityAll = new List<Object>();


        public Region(String nam, String loc, double squ, int popul, List<Object> city) : base(nam, loc, squ, popul)
        {
            cityAll = city;

        }
        public Region(String nam, String loc, double squ, int popul) : base(nam, loc, squ, popul)
        {
        }

        public event EventHandler sityAdd;

        public void add_city(City city)
        {
            cityAll.Add(city);
            sityAdd();
            population_people(city.Population, "+");
        }

        public void add_megapolice(Megapolice megapolice)
        {
            cityAll.Add(megapolice);
            population_people(megapolice.Population, "+");
        }
    }
}
