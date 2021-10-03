using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Interfaces
{
    interface IInitInterface
    {
        string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }
}
