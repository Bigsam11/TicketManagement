using Viagogo.Helper;
using Viagogo.Models;

namespace Viagogo.Helpers
{
    public class ResolvePrice
    {
        public static int GetPrice(Event e)
        {
            return (DistanceImpl.AlphabeticalDistance(e.City, "") + DistanceImpl.AlphabeticalDistance(e.Name, ""))  / 10;
        }

    }
}