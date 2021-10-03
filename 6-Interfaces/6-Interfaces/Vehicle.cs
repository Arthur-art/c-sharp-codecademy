using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Interfaces
{
    class Vehicle
    {
        public string LicensePlate { get; set; }

        public double Speed { get; set; }

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
