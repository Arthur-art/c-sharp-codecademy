using _6_Interfaces;
using System;

namespace LearnInterfaces
{
    class Truck : Vehicle, IAutomobile
    {

        public Truck(double speed, double weight):base(speed)
        {
          
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public double Weight { get; set; }

        public override string Describle()
        {
            return $"This truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

    }
}