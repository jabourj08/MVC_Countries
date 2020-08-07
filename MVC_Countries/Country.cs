using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    public enum Continents
    {
        NorthAmerica,
        SouthAmerica,
        Europe,
        Africa,
        Asia,
        Australia,
        Antarctica
    }
    class Country
    {
        //Properties
        public string Name { get; set; }
        public Continents Continent { get; set; }
        public List<string> Colors { get; set; }

        //Constructors
        public Country() { }
        public Country(string Name, Continents Continent, List<string> Colors)
        {
            this.Name = Name;
            this.Continent = Continent;
            this.Colors = Colors;
        }
    }
}
