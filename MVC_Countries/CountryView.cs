using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MVC_Countries
{
    class CountryView
    {
        //Properties
        public Country DisplayCountry { get; set; }
        //Constructors
        public CountryView() { }
        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        //Methods
        public void Display(Country country)
        {
            Console.Clear();
            Console.WriteLine("Here is the information on your country:");
            Console.WriteLine();
            Console.WriteLine($"Country Name: {country.Name}");
            Console.WriteLine($"Continent: {country.Continent}");
            Console.Write($"Colors: ");
            int count = 1;
            foreach (string color in country.Colors)
            {
                if (count == (country.Colors.Count))
                {
                    Console.Write($"{color}");
                }
                else
                {
                    Console.Write($"{color}, ");
                }
                count++;
            }

            Console.WriteLine();
            Console.WriteLine();
            if (country.Name == "United States of America")
            {
                AmericanFlag();
            }
            else if (country.Name == "Italy")
            {
                ItalianFlag();
            }
            else if (country.Name == "Lebanon")
            {
                LebaneseFlag();
            }
            else if (country.Name == "Venezuela")
            {
                VenezuelanFlag();
            }
            else if (country.Name == "Belgium")
            {
                BelgianFlag();
            }
            else if (country.Name == "Madagascar")
            {
                MadagascanFlag();
            }
            else if (country.Name == "Dominican Republic")
            {
                DominicanRepublicFlag();
            }

            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Press any key to return to the list view.");
            Console.ReadKey();
        }

        //American Flag
        public void AmericanFlag()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 13; i++)
            {
                if (i < 7)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write("*");
                            }
                        }
                        for (int j = 0; j < 40; j++)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write(" ");
                            }
                        }
                        for (int j = 0; j < 40; j++)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                        }
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < 60; j++)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 60; j++)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        //Italian Flag
        public void ItalianFlag()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" ");
                }
                for (int j = 0; j < 20; j++)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
                for (int j = 0; j < 20; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
        //Lebanese Flag
        public void LebaneseFlag()
        {
            for (int i = 0; i < 7; i++)
            {
                if (i < 3)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                else if (i == 3)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("                            /\\                              ");
                    Console.WriteLine("                           /**\\                             ");
                    Console.WriteLine("                          /****\\                            ");
                    Console.WriteLine("                         /******\\                           ");
                    Console.WriteLine("                        /********\\                          ");
                    Console.WriteLine("                           |__|                             ");
                }
                else
                {
                    for (int j = 0; j < 60; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
        //Venezuelan Flag
        public void VenezuelanFlag()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i < 4)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                else if (i == 4)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                            *  *                            ");
                    Console.WriteLine("                         *        *                         ");
                    Console.WriteLine("                       *            *                       ");
                    Console.WriteLine("                      *              *                      ");
                }
                else
                {
                    for (int j = 0; j < 60; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
        //Belgian Flag
        public void BelgianFlag()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                }
                for (int j = 0; j < 20; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(" ");
                }
                for (int j = 0; j < 20; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
        //Madagascan Flag
        public void MadagascanFlag()
        {
            for (int i = 0; i < 14; i++)
            {
                if (i < 7)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 45; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" ");
                    }
                }
                else
                {
                    for (int j = 0; j < 15; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 45; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
        //Dominican Republic Flag
        public void DominicanRepublicFlag()
        {
            for (int i = 0; i < 13; i++)
            {
                if (i < 5)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 10; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 25; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" ");
                    }
                }
                else if (i < 8)
                {
                    for (int j = 0; j < 60; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }
                }
                else
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 10; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 25; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" ");
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}
