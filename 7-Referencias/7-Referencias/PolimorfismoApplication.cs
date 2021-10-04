using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Referencias
{
   class PolimorfismoApplication : PolimorfismoClass
    {

        public static void  helloWorld()
        {
            Console.WriteLine("Hello polimorfismo");
        }

        public override void hello()
        {
            Console.WriteLine("Hallo");
        }
    }
}
