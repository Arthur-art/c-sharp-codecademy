using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Referencias
{
    class PolimorfismoClass
    {
        public static void helloWorld()
        {
            Console.WriteLine("Hello World");
        }

        public virtual void hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
