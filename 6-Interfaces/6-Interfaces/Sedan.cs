using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Interfaces
{
    class Sedan : IAutomobile
    {

        public string LicensePlate { get; }

        public double Speed { get; private set; }

        public int Wheels { get; }

        public void Honk()
        {
            Console.WriteLine("Trabalhando com Interfaces");
        }

        public Sedan(double speed)
        {
            Speed = speed;
            LicensePlate = "91821928";
            Wheels = 4;
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
