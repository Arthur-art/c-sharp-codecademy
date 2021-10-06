using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listString = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };


            foreach (string value in listString)
            {
                if(value.Length > 6)
                {
                    Console.WriteLine(value);
                }
            }

            var listLinq = from value in listString
                           where value.Length > 6
                           select value;

            Console.WriteLine(string.Join(",", listLinq));
        }
    }
}
