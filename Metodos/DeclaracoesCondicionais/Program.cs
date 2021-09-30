using System;

namespace DeclaracoesCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metodos simples do C#

            string msg = "Yabba dabba doo!";

            Math.Min(10, 12);

            Console.WriteLine(msg);

            var firstLetter =  msg.Substring(0, 1);

            Console.WriteLine(firstLetter);

            // Metodos void 

            static void VisitPlanets()
            {
                Console.WriteLine("Mars");
            }
            VisitPlanets();
        }
    }
}
