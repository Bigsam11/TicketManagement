using System;

namespace Viagogo.Helper
{
    public class DistanceImpl
    {
        public static int GetDistance(string fromCity, string toCity)
        {
            return AlphabeticalDistance(fromCity, toCity);
        }


        public static int AlphabeticalDistance(string s, string t)
        {
            var result = 0;
            var i = 0;
            for (i = 0; i < Math.Min(s.Length, t.Length); i++)
            {
                //Console.Out.WriteLine($"loop 1 i={i} {s.Length} {t.Length}");
                result += Math.Abs(s[i] - t[i]);
            }

            for (;
                 i
                 <
                 Math.Max(s.Length, t.Length);
                 i++)
            {
                //Console.Out.WriteLine($"loop 2 i={i} {s.Length} {t.Length}");
                result += s.Length > t.Length ? s[i] : t[i];
            }

            return result;
        }

    }
}