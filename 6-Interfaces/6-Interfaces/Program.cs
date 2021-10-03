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

            Console.WriteLine(firstSedan.Speed);
            Console.WriteLine(firstSedan.Wheels);
            Console.WriteLine(firstSedan.LicensePlate);

            Console.WriteLine(secondSedan.Speed);
            Console.WriteLine(secondSedan.Wheels);
            Console.WriteLine(secondSedan.LicensePlate);

            Console.WriteLine(firstTruck.Speed);
            Console.WriteLine(firstTruck.Wheels);
            Console.WriteLine(firstTruck.LicensePlate);

            firstSedan.SpeedUp();
            secondSedan.SpeedUp();
            firstTruck.SpeedUp();

            Console.WriteLine(firstSedan.Speed);
            Console.WriteLine(secondSedan.Speed);
            Console.WriteLine(firstTruck.Speed);
        }
    }
}
