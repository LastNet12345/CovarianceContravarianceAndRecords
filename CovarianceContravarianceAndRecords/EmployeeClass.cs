using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravarianceAndRecords
{
    internal class EmployeeClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public EmployeeClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Deconstruct(out string name, out int age) => (name, age) = (Name, Age); 
        //{ 
        //    name= Name;
        //    age = Age;
        //}

    }

    internal record EmployeeRecord(string Name, int Age);

    internal record EmployeeRecord2
    {
        public string Name { get; init; }
        public int Age { get; set; }
        public EmployeeRecord2(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }

    internal record EmpRec<T>(List<T> Users);
}
