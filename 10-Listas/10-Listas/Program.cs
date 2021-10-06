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
            bool removed = cestaFrutas.Remove("Pera");
            Console.WriteLine(cestaFrutas.Count);
            Console.WriteLine(cestaFrutas.Contains("Morango"));
            Console.WriteLine(string.Join(",", cestaFrutas));

            // Range

            List<int> seconds = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12 };

            List<int> getSeconds = seconds.GetRange(0, 3);

            Console.WriteLine(string.Join(",", getSeconds));

            foreach(int value in getSeconds)
            {
                Console.WriteLine(value);
            }
        }
    }
}
