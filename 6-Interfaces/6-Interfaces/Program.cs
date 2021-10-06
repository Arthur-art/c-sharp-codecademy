using LearnInterfaces;
using System;

namespace _6_Interfaces
{
    /*
Análise

Bem feito! Você aprendeu muito rapidamente, então vamos fazer uma revisão:

A herança é uma forma de evitar a duplicação em várias classes.

Na herança, uma classe herda os membros de outra classe.

A classe que herda é chamada de subclasse ou classe derivada . A outra classe é chamada de superclasse ou classe base .

Podemos acessar os membros de uma superclasse usando base. Isso é muito útil ao chamar o construtor da superclasse.

Podemos restringir o acesso a uma superclasse e suas subclasses usando protected.

Podemos substituir um membro da superclasse usando virtuale override.

Podemos fazer um membro em uma superclasse sem definir sua implementação usando abstract. Isso é útil se a implementação de cada subclasse for diferente.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Sedan firstSedan = new Sedan(60);
            Sedan secondSedan = new Sedan(70);
            Truck firstTruck = new Truck(45, 500);

            Console.WriteLine("firstSedan.Speed "+firstSedan.Speed);
            Console.WriteLine("firstSedan.Wheels "+firstSedan.Wheels);
            Console.WriteLine("firstSedan.LicensePlate "+firstSedan.LicensePlate);

            Console.WriteLine("secondSedan.Speed "+secondSedan.Speed);
            Console.WriteLine("secondSedan.Wheels "+secondSedan.Wheels);
            Console.WriteLine("secondSedan.LicensePlate " + secondSedan.LicensePlate);

            Console.WriteLine("firstTruck.Speed "+firstTruck.Speed);
            Console.WriteLine("firstTruck.Wheels "+firstTruck.Wheels);
            Console.WriteLine("firstTruck.LicensePlate "+firstTruck.LicensePlate);

            firstSedan.SpeedUp();
            secondSedan.SpeedUp();
            firstTruck.SpeedUp();

            Console.WriteLine("firstSedan.Speed "+firstSedan.Speed);
            Console.WriteLine("secondSedan.Speed "+secondSedan.Speed);
            Console.WriteLine("firstTruck.Speed "+firstTruck.Speed);

            Bicycle b = new Bicycle(5);
            b.SpeedUp();
            b.SpeedDown();

            Console.WriteLine("b.Speed "+b.Speed);

            Console.WriteLine("b.Describle() " + b.Describle());

            Console.WriteLine("firstSedan.Describle() " + firstSedan.Describle());

            Console.WriteLine("firstTruck.Describle() " + firstTruck.Describle());

            Sedan teste = new Sedan(12.90);

            Console.WriteLine(teste.Speed);

            teste.SpeedUp();

            Console.WriteLine(teste.Speed);
        }
    }
}
