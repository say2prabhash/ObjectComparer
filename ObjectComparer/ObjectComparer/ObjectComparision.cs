using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class ObjectComparision:IComparer
    {
        public bool Comparer(object o1, object o2)
        {

            Type t1 = o1.GetType();
            Type t2 = o2.GetType();
            if (t1.Equals(t2) && (o1 != null && o2 != null))
            {
                PropertyComparision propertyCompare = new PropertyComparision();
                if(propertyCompare.PropertyComparer(t1, t2,o1,o2))
                {
                    return true;
                }
            }
            return false;


        }
    }
}
