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

            CountryController controller = new CountryController();

            controller.WelcomeAction();
            
        }
    }
}
