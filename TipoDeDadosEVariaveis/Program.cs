using System;

namespace TipoDeDadosEVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de variaveis

            
            string name = "Arthur";
            int age = 25;
            double weight = 75.5;
            bool dev = true;
            decimal money = 10500.65m;
            Console.WriteLine($"{name} { age} { weight} { dev} {money}");
            

            //Convertendo variaveis, Console.ReadLine sempre irá retornar uma string, convertendo seu valor para um int

            
            Console.WriteLine("Digite um numero");
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero digitado, {faveNumber}");
            


            // Operadores aritméticos

            // Your Age
            int userAge = 30;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine(jupiterAge);
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);

            // operador modulo

            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 4;

            // Does groupSize go evenly into students?
            Console.WriteLine(students % groupSize);
        }
    }
}
