using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    class ValueComparision
    {
        public bool ValueComparer<T>(T v1, T v2)
        {
            if (v1.Equals(v2))
            {
                return true;
            }
            return false; 
        }
    }
}
