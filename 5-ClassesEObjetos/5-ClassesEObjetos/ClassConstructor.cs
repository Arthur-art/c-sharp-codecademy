using System;
using System.Collections.Generic;
using System.Text;

namespace _5_ClassesEObjetos
{
    class ClassConstructor
    {
        public ClassConstructor(string name, int age=25)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
