using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Class1
    {
        public int id;
        public string firstName, middleName, lastName, dept;

        public Class1(int id, string firstName, string middleName, string lastName, string dept)
        {
            this.id = id;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.dept = dept;
        }
        public Class1() { }
    }
}
