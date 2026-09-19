using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Employee : IComparable<Employee> , ICloneable
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public object Clone()
        {
            return new Employee
            {
                Name=this.Name,
                Salary=this.Salary
            };
        }

        public int CompareTo(Employee other)
        {
            return Salary.CompareTo(other.Salary);
        }

        public override string ToString()
        {
            return $"name: {Name} , Salary: {Salary}";
        }
    }
}
