using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
   public class Class1<T>
    {
        public T A { get; private set; }
        public Class1(T a)
        {
            A = a;
        }
    }
}
