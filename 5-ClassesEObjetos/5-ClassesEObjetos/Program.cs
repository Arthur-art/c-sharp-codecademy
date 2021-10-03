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
            

            // Classes constructor

            ClassAutomatica c = new ClassAutomatica("Arthur", 25, "Dev");

            c.Name = "hoje";

            var resultNum = c.sum(12, 12);

            Console.WriteLine(resultNum);

            ClassConstructor cc = new ClassConstructor("Arthur");

            Console.WriteLine(cc.Age);
        }
    }
}
