using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
   public class Person
    {
        public int Id { get; }
        public string Name { get; private set; }
        public Employee Emp { get; private set; }
        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
            Id = 1;
            Emp = new Employee(name);
        }
    }
}
