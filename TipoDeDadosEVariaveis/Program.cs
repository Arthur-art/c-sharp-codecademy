using System;

namespace TipoDeDadosEVariaveis
{
   public class Program
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

          //  Console.WriteLine("Digite um numero");
          //  int faveNumber = Convert.ToInt32(Console.ReadLine());
          //  Console.WriteLine($"Numero digitado, {faveNumber}");
            


            // Operadores aritméticos

            
            int userAge = 30;

            double jupiterYears = 11.86;

            double jupiterAge = userAge / jupiterYears;

            double journeyToJupiter = 6.142466;

            double newEarthAge = userAge + journeyToJupiter;

            double newJupiterAge = newEarthAge / jupiterYears;

           // Console.WriteLine(jupiterAge);
           // Console.WriteLine(newEarthAge);
           // Console.WriteLine(newJupiterAge);
            

            // Operador modulo

            
            int students = 18;

            int groupSize = 4;
            
           // Console.WriteLine(students % groupSize);
            

            // Metodos integrados

            int num1 = 121311;
            int num2 = -9319031;

            double num1Sqrt = Math.Floor(Math.Sqrt(num1));
            double num2Sqrt = Math.Floor(Math.Sqrt(Math.Abs(num2)));

          //  Console.WriteLine(Math.Min(num1Sqrt, num2Sqrt));

            int num12 = 12;
            int num19 = 19;

            double num1Ceiling = 12.5;
            double num2Ceiling = 12.6;
            double num3Ceiling = 12.4;


            Console.WriteLine($"Metodo Ceiling {Math.Ceiling(num3Ceiling)}");
            Console.WriteLine($"Metodo Floor {Math.Floor(num3Ceiling)}");
            Console.WriteLine($"Metodo Pow {Math.Pow(2, 2)}");
            // Console.WriteLine(Math.Max(num12, num19));


            /*Também podemos usar métodos .NET integrados para capturar partes de strings ou caracteres específicos em uma string.*/

            //Substring and IndexOf

            string plantName = "Cactus, Cactaceae";

            int charPosition = plantName.IndexOf("Cactaceae");

            string commonName = plantName.Substring(charPosition);

            Console.WriteLine($"commonName {commonName}");

        }
    }
}
