using System;
using System.Collections.Generic;

namespace practicum_05_upr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countryLookup = new Dictionary<int, string>();
            countryLookup[44] = "United Kingdom"; 
            countryLookup[33] = "France";
            countryLookup[31] = "Netherlands"; 
            countryLookup[55] = "Brazil";
            //countryLookup["64"] = "New Zealand";
            Console.WriteLine("The 33 Code is for: {0}", countryLookup[33]);
            foreach (KeyValuePair<int, string> item in countryLookup)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine("Code {0} = {1}", code, country);
            }
            Console.Read();
        }
    }
}
