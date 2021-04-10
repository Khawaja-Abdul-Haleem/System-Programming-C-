using System;
using System.Collections.Generic;
using System.Text;

namespace UserDefine_datatype
{
    class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", Name, Gender, Age, Salary);
        }

    }
}
