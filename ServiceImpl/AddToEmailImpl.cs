using System;
using Viagogo.Models;

namespace Viagogo.Helper
{
    public class AddToEmailImpl
    {
        public static void AddToEmail(Customer c, Event e, int? price = null)
        {
            var distance = DistanceImpl.GetDistance(c.City, e.City);
            Console.Out.WriteLine($"{c.Name}: {e.Name} in {e.City}"
                                  + (distance > 0 ? $" ({distance} miles away)" : "")
                                  + (price.HasValue ? $" for ${price}" : ""));
        }

    }
}