using System;

namespace _5_ClassesEObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Classes no C#

            BasicClass b = new BasicClass();

            b.name = "Arthur";
            b.job = "Dev";
            b.age = 25;

            Console.WriteLine(b.name);
        }
    }
}
