using System;

namespace _5_ClassesEObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Classes no C#

            BasicClass b = new BasicClass();

            b.Name = "Arthur";
            b.Job = "Developer";
            b.Age = 25;

            Console.WriteLine(b.Job);
        }
    }
}
