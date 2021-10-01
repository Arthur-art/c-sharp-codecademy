using System;

namespace DeclaracoesCondicionais
{
    class Program
    {
        // Sobrecarga de metodos
        static void NamePets(string name1, string name2)
        {
            Console.WriteLine($"Your pets {name1} and {name2} will be joining your voyage across space!");
        }

        static void NamePets(string name1, string name2, string name3)
        {
            Console.WriteLine($"Your pets {name1} and {name2} will be joining your voyage across space!");
        }

        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        }
        static void Main(string[] args)
        {
            // Metodos simples do C#

            string msg = "Yabba dabba doo!";

            Math.Min(10, 12);

            Console.WriteLine(msg);

            var firstLetter = msg.Substring(0, 1);

            Console.WriteLine(firstLetter);

            // Metodos void 

            static void VisitPlanets()
            {
                Console.WriteLine("Mars");
            }
            VisitPlanets();

            // Metodos com parametros

            static void NumberPlanets(int qtd)
            {
                Console.WriteLine($" A galaxia possui {qtd} planetas");
            }
            NumberPlanets(10);

            // Metodos com parametros opcionais

            static void PlanetsTrue(int qtd = 0)
            {
                Console.WriteLine($" A galaxia possui {qtd} planetas");
            }
            PlanetsTrue();

            // Argumentos Nomeados

            static void ArgsNomeados(int a = 1, int b = 2, int c = 3, int d = 4, int e = 5)
            {
                Console.WriteLine($"a:{a} b:{b} c:{c} d:{d} e:{e}");
            }
            ArgsNomeados(d: 50);

            NamePets();

            // Metodos com retorno

            static string ReturnPlanet(string planetName)
            {
                return planetName;
            }

            Console.WriteLine(ReturnPlanet("Mars"));

            var planet = ReturnPlanet("MarsMission");

            Console.WriteLine(planet);

            static bool FalseTrue()
            {
                return true;
            }

            // Metodo out

            string ageAsString = "12345";
            int ageAsInt;
            bool outcome;

            outcome = Int32.TryParse(ageAsString, out ageAsInt);

            Console.WriteLine($"outcome => {outcome}");

            // Arrow functions

            static void arrowFunction() => Console.WriteLine("ArrowFunction");

            arrowFunction();

            // Metodos como argumentos

            string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };

            static bool MaiorPalavra(string palavra)
            {
                return palavra.Length > 8;
            }

            string palavra = Array.Find(adjectives, MaiorPalavra);

            Console.WriteLine(palavra);

            // functions lambdas

            int[] arrayNumber = {1, 2, 3, 4, 5, 6, 7, 8};

            int[] numParArray = Array.FindAll(arrayNumber, (value) => value % 2 == 0);

            Console.WriteLine(string.Join(",", numParArray));


        }

    }
}
