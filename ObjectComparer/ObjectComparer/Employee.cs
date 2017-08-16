using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class Employee
    {
        public string EmpName { get; private set; }
        public Employee(string name)
        {
            EmpName = name;
        }
    }
}
