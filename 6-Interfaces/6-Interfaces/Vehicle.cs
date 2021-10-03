using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Interfaces
{
   abstract class Vehicle
    {

       public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = "91821928";
        }
        public string LicensePlate { get; protected set; }

        public double Speed { get; protected set; }

        public int Wheels { get; protected set; }

        public void Honk()
        {
            Console.WriteLine("Trabalhando com Interfaces");
        }

        public virtual void SpeedUp()
        {
            Speed += 1;
        }

        public virtual void SpeedDown()
        {
            Speed -= 1;
        }

        public abstract string Describle();

    }
}
