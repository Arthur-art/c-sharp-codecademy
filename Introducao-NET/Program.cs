using System;

namespace Introducao_NET
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");

            //Laço de repetição e concatenacao com c#

            
            int numCinco = 5;
            for(int i=0; i<numCinco; i++)
            {
                Console.WriteLine($"Praticando laço de repetição com dotnet, {i}");
            }
            


            //Escrevendo e lendo valores

            
            Console.WriteLine("Ola, qual a sua idade ?");
            string input = Console.ReadLine();
            Console.WriteLine($"A sua idade é {input}");
            

        }
    }
}
