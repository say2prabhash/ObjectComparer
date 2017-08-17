using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using ObjectComparer;

namespace ObjectComparerTest
{
    public class ObjectReferenceTest
    {
        [Fact]
        public void Object_Reference_Test_Method()
        {
            Person p = new Person("Prabhash");
            Person p1 = new Person("Prabhash");
            Employee e = new Employee("Xyz");
            ObjectComparision compare = new ObjectComparision();
            Assert.True(compare.Comparer(p, p1));
            Assert.False(compare.Comparer(p, e));
        }
        [Fact]
        public void Object_Not_Null_Reference_Test_Method()
        {
            Person p = new Person("Prabhash");
            Person p1 = new Person("");
            ObjectComparision compare = new ObjectComparision();
            Assert.False(compare.Comparer(p, p1));
        }
        [Fact]
        public void Object_Properties_Equality_Test()
        {
            Person p = new Person("Prabhash");
            Person p1 = new Person("");
            Employee e = new Employee("xyz");
            ObjectComparision compare = new ObjectComparision();
            Assert.False(compare.Comparer(p, p1));
            Assert.False(compare.Comparer(p, e));
        }
        [Fact]
        public void Property_Is_Class_TestMethod()
        {
            Person p = new Person("Prabhash");
            Person p1 = new Person("Prabhash");
            Employee e = new Employee("xyz");
            ObjectComparision compare = new ObjectComparision();
            Assert.True(compare.Comparer(p, p1));
            Assert.False(compare.Comparer(p, e));
        }
        [Fact]
        public void Property_Is_Generic_Type_Test_Method()
        {
            Person p1 = new Person("Prabhash");
            Person p2 = new Person("Prabhash");
            Class1<Person> c = new Class1<Person>(p1);
            Class1<int> c1 = new Class1<int>(1);
            Class1<Person> c2 = new Class1<Person>(p2);
            ObjectComparision compare = new ObjectComparision();
            Assert.False(compare.Comparer(c,c1));
            Assert.True(compare.Comparer(c, c2));
        }

    }
}
