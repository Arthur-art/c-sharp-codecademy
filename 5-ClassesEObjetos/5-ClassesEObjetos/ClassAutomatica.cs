using System;
using System.Collections.Generic;
using System.Text;

namespace _5_ClassesEObjetos
{
    class ClassAutomatica
    {
        public ClassAutomatica(string name, int age, string job)
        {
            Name = name;
            Age = age;
            Job = job;
        }

        private string name;

        public string Name { get; set; }

        public int Age { get; set; }

        public string Job { get; set; }

        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
