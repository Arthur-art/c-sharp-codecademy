using LearnInterfaces;
using System;

namespace _6_Interfaces
{
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
        }
    }
}
