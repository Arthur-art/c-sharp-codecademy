using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Interfaces
{
    class Sedan : Vehicle, IAutomobile
    {

        public Sedan(double speed)
        {
            Speed = speed;
            LicensePlate = "91821928";
            Wheels = 4;
        }

       
    }
}
