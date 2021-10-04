using System;
using System.Collections.Generic;

namespace _10_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> marathons = new List<double>();

            marathons.Add(133.42);
            marathons.Add(421.43);

            foreach(double value in marathons)
            {
                Console.WriteLine(value);
            }

            List<string> cestaFrutas = new List<string> { "Maçã","Banana","Pera","Morango"};
            cestaFrutas.Add("Uva");

            Console.WriteLine(cestaFrutas.Count);
            Console.WriteLine(cestaFrutas.Contains("Morango"));
        }
    }
}
