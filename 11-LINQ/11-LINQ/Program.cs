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

            // Sintaxe de consulta basica

            var heroesWithI = from hero in listString
                              where hero.Contains("i")
                              select hero;
            Console.WriteLine(string.Join(",", heroesWithI));

            var heroesUnderscored = from hero in listString
                                    select hero.Replace(" ", "_");

            Console.WriteLine(string.Join(",", heroesUnderscored));

            // Sintaxe de metodo basico : Where

            IEnumerable<string> shortHeroes = listString.Where(hero => hero.Length < 8);

            IEnumerable<string> heroeWithI = listString.Where(hero => hero.Contains("i"));

            Console.WriteLine("shortHeroes: "+string.Join(",",shortHeroes));

            // Sintaxe de metodo basico : Select

            IEnumerable<string> listStringToUpperCase = listString.Select(value => value.ToUpper());
            foreach(string value in listStringToUpperCase)
            {
                Console.WriteLine(value);
            }

            IEnumerable<string> listSelectWhere = listString
                .Where(value => value.Contains("c"))
                .Select(value => value.ToLower());
                

            foreach (string value in listSelectWhere)
            {
                Console.WriteLine(value);
            }

            // Praticando

            string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

            IEnumerable<string> formatheroes = heroes.Select(value => $"Introducing...[{value}]!");

            var consultList = from hero in heroes
                              where hero.Contains(" ")
                              select Array.IndexOf(heroes, hero);

        }
    }
}
