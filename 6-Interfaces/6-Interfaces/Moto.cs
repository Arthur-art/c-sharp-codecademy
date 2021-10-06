using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Interfaces
{
    class Moto : Vehicle, IAutomobile
    {
        public Moto(double speed) : base(speed)
        {
           
        }

        public override string Describle()
        {
            throw new NotImplementedException();
        }
    }
}
