using System;
using System.Linq;
using System.Collections.Generic;
using WhatsForLunch;

namespace WhatsForLunch
{
    class Program
    {
        static void Main(string[] args)

        {

            var lunchBuddy = new LunchBuddy
            {
                FirstName = "Carl",
                LastName = "Levert",
            };

            Console.WriteLine(lunchBuddy.FirstName);
        }
    }
}
