using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Manager : Employee, IComparable<Manager>
    {
        public int CompareTo(Manager other)
        {
           return Salary.CompareTo(other.Salary);
        }
    }
}
