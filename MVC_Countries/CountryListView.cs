using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    class CountryListView
    {
        //Properties
        public List<Country> Countries { get; set; }

        //Constructors
        public CountryListView() { }
        public CountryListView (List<Country> Countries)
        {
            this.Countries = Countries;
        }

        //Methods
        public void Display()
        {
            int index = 0;
            foreach (Country country in Countries)
            {
                Console.WriteLine($"Index {index}: {country.Name}");
                index++;
            }
        }
    }
}
