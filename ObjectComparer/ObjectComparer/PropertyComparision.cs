using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    class PropertyComparision
    {
        public bool PropertyComparer(object a1, object a2,object o1,object o2)
        {
            dynamic t1 = a1;
            dynamic t2 = a2;
            dynamic obj1 = o1;
            dynamic obj2 = o2;
            PropertyInfo[] p1 = t1.GetProperties();
            PropertyInfo[] p2 = t2.GetProperties();
            if (Equals(p1, p2,obj1,obj2))
            {

                return true;
            }
            return false;
        }
        public bool Equals(PropertyInfo[] obj1, PropertyInfo[] obj2,object o1,object o2)
        {
            int k = 0;
            int length = 0;
            foreach (PropertyInfo p in obj2)
            {
                Type t = obj1[k].PropertyType;
                // var a = obj1[k].GetValue();
                if (((obj1[k].PropertyType)).Equals(p.PropertyType) && (t.IsPrimitive) || t.Name.Equals("String"))
                {
                    ValueComparision compare = new ValueComparision();
                    if (compare.ValueComparer(obj1[k].GetValue(o1), p.GetValue(o2)))
                    {
                        length++;
                    }
                }
                else
                {
                    if (PropertyComparer(obj1[k].PropertyType, obj2[k].PropertyType,obj1[k].GetValue(o1),obj2[k].GetValue(o2)))
                    {
                        length++;
                    }
                }
                k++;
            }
            if (length == obj1.Length && length == obj2.Length)
            {
                return true;
            }
            return false;
        }
    }
}
