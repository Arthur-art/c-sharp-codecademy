using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Interfaces
{
    class Vehicle
    {

       public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = "91821928";
        }
        public string LicensePlate { get; private set; }

        public double Speed { get; private set; }

        public int Wheels { get; set; }

        public void Honk()
        {
            Console.WriteLine("Trabalhando com Interfaces");
        }

        public void SpeedUp()
        {
            Speed += 1;
        }

        public void SpeedDown()
        {
            Speed -= 1;
        }
    }
}
