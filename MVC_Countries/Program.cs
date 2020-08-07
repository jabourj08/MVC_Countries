using System;
using System.Collections.Generic;
using System.Drawing;

namespace MVC_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            List<Country> myCountries = new List<Country>()
            {
                new Country("United States of America", Continents.NorthAmerica, (new List<string>(){ "Red", "White", "Blue"})),
                new Country("Italy", Continents.Europe, (new List<string>(){ "Green", "White", "Red"})),
                new Country("Lebanon", Continents.Asia, (new List<string>(){ "Red", "White", "Green"})),
                new Country("Belgium", Continents.Europe, (new List<string>(){ "Black", "Yellow", "Red"})),
                new Country("Venezuela", Continents.SouthAmerica, (new List<string>(){ "Yellow", "Blue", "Red"})),
                new Country("Madagascar", Continents.Africa, (new List<string>(){ "White", "Red", "Green"})),
                new Country("Dominican Republic", Continents.NorthAmerica, (new List<string>(){ "Red", "White", "Blue"})),
            };

            CountryController controller = new CountryController();

            controller.CountryDb = myCountries;

            controller.WelcomeAction();
            
        }
    }
}
