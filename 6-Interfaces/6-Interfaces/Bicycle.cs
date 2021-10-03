using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Interfaces
{
    class Bicycle : Vehicle
    {
        public Bicycle(double speed) : base(speed)
        {
            Wheels = 2;
        }

        public override void SpeedUp()
        {
            Speed += 5;
        }
         
        public override void SpeedDown()
        {
            Speed -= 5;
        }

        public override string Describle()
        {
            return $"This bicycle is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }
    }
}
