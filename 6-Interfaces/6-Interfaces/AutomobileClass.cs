using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Interfaces
{
    class AutomobileClass : IAutomobile
    {
        public string LicensePlate { get; }

        public double Speed { get; }

        public int Wheels { get; }

        public void Honk()
        {
            Console.WriteLine("Trabalhando com Interfaces");
        }
    }
}
