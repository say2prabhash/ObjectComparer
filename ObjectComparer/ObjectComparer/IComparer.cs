using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    interface IComparer
    {
        bool Comparer(object o1, object o2);
    }
}
