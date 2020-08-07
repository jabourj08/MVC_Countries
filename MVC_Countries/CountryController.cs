using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MVC_Countries
{
    class CountryController
    {
        //Properties
        public List<Country> CountryDb { get; set; }

        //Methods
        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display(c);
        }

        public void WelcomeAction()
        {
            bool cont = true;
            while (cont)
            {
                CountryListView view = new CountryListView(CountryDb);
                Console.WriteLine($"Hello, welcome to the country app. Please select a country from the following list: ");
                Console.WriteLine();
                view.Display();
                Console.WriteLine();
                Console.Write($"Please select a country by index (0 - {CountryDb.Count - 1}): ");
                int index = CheckNumber(Console.ReadLine(), true, (CountryDb.Count - 1));

                CountryAction(CountryDb[index]);

                Console.Write("Would you like to learn about another country? Enter y/n: ");
                string input = CheckDecision(Console.ReadLine());
                Console.WriteLine();
                if (input == "n")
                {
                    cont = false;
                }
            }
        }

        //Check for number
        public int CheckNumber(string input, bool rangeCheck, int num)
        {
            int validNumber = 0;
            bool invalid = true;
            while (invalid)
            {
                try
                {
                    validNumber = int.Parse(input);

                    if (rangeCheck)
                    {
                        if (validNumber >= 0 && validNumber <= num)
                        {
                            invalid = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Why u no listen??? I said enter a number from 0 - " + num + ".");
                            Console.ForegroundColor = ConsoleColor.Black;
                            BeepBoops();
                            Console.Write("Please try again: ");
                            input = Console.ReadLine();
                        }
                    }
                    else
                    {
                        invalid = false;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Why u no listen??? Enter a number");
                    Console.ForegroundColor = ConsoleColor.Black;
                    BeepBoops();
                    Console.Write("Please try again: ");
                    input = Console.ReadLine();
                }
            }
            return validNumber;
        }
        //Check for y/n
        public string CheckDecision(string input)
        {
            bool invalid = true;
            while (invalid)
            {
                if (input.ToLower() == "y")
                {
                    input = "y";
                    invalid = false;
                }
                else if (input.ToLower() == "n")
                {
                    input = "n";
                    invalid = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Why u no listen??? I said enter y/n");
                    Console.ForegroundColor = ConsoleColor.Black;
                    BeepBoops();
                    Console.Write("Please try again: ");
                    input = Console.ReadLine();
                }
            }
            return input;
        }
        //Addz Cool Zoundz!!! Because why not??
        public static void BeepBoops()
        {
            Console.Beep(1000, 50); Console.Beep(1000, 50); Console.Beep(1000, 50);
            Console.Beep(2000, 50); Console.Beep(2000, 50); Console.Beep(2000, 50);
        }
    }
}
