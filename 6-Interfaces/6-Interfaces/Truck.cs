using _6_Interfaces;
using System;

namespace LearnInterfaces
{
    class Truck : Vehicle, IAutomobile
    {

        public Truck(double speed, double weight)
        {
            Speed = speed;
            LicensePlate = "1313311";
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

    }
}