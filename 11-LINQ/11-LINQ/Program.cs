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

            var listLinq = listString
                .Where(x => x.Length > 6);
                

            Console.WriteLine(string.Join(",", listLinq));

            // Métodos e sintaxes de consulta LINQ

            var queryResult = from value in listString
                              where value.Contains("a")
                              select $"A palavra {value} contem a letra a";

            Console.WriteLine(string.Join(", ",queryResult));

            var resultMethod = listString
                .Where(value => value.Contains("a"))
                .Select(value => $"A palavra {value} contem a letra a");

            Console.WriteLine(string.Join(", ", resultMethod));
        }
    }
}
