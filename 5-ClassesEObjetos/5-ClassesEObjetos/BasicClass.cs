using System;
using System.Collections.Generic;
using System.Text;

namespace _5_ClassesEObjetos
{
    class BasicClass
    {
        public string name;
        public string job;
        public int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Job
        {
            get { return job; }
            set
            {
                if(value == "Dev" || value == "Developer")
                {
                    job = value;
                }
                else
                {
                    job = "null";
                }
            }
        }
    }
}
