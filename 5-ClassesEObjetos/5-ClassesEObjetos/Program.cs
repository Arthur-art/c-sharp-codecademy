using StaticMembers;
using System;

namespace _5_ClassesEObjetos
{
    class Program
    {


        /*
        Main()é um método da Programclasse.

        public- O método pode ser chamado fora da Programclasse.

        static- O método é chamado a partir do nome da classe: Program.Main().

        void - O método significa não retorna nada.

        string[] args- O método tem um parâmetro denominado args, que é uma matriz de strings.

        Cada vez que executamos dotnet run, o Main()método é chamado. Podemos incluir argumentos na linha de comando,
        como se dotnet run arg1 arg2 arg3isso fosse convertido em um array como argsparâmetro.
         */
        static void Main(string[] args)
        {

            // Classes no C#

            BasicClass b = new BasicClass();

            b.Name = "Arthur";
            b.Job = "Developer";
            b.Age = 25;

           

            Console.WriteLine(b.Job);
            

            // Classes constructor

            ClassAutomatica c = new ClassAutomatica("Arthur", 25, "Dev");

            c.Name = "hoje";

            var resultNum = c.sum(12, 12);

            Console.WriteLine(resultNum);

            ClassConstructor cc = new ClassConstructor("Arthur");

            Console.WriteLine(cc.Age);

            // Classes Estaticas

            Console.WriteLine(Math.PI);

            Console.WriteLine(Math.Abs(-32));

            Forest f = new Forest("Congo", "Tropical");

            f.Grow();

            Console.WriteLine(Forest.TreeFacts);
        }
    }
}
