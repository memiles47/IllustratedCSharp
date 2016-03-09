using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp_CodeTesting_Ch7
{
    class SomeClass                     //Base class
    {
        public string field1 = "Base class field";

        public void Method1(string value)
        {
            Console.WriteLine($"Base class -- Method1: {value}");
        }
    }

    class OtherClass: SomeClass         //Derived class
    {
        public string field2 = "Derived class field";

        public void Method2(string value)
        {
            Console.WriteLine($"Derived class -- Method2: {value}");
        }
    }

    class AnotherClass: OtherClass
    {
        new public string field2 = "Derived class field2 masking field from OtherClass";

        new public void Method2(string value)
        {
            Console.WriteLine($"Derived class -- Masked Method2: {value}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OtherClass OC = new OtherClass();
            AnotherClass AC = new AnotherClass();

            //Inheritance
            OC.Method1(OC.field1);      //Base method with base field
            OC.Method1(OC.field2);      //Base method with derived field
            OC.Method2(OC.field1);      //Derived method with base field
            OC.Method2(OC.field2);      //Derived method with derived field

            //Inheritance with two classes, masking a field and a method
            AC.Method1(AC.field1);      //Base method with base field
            AC.Method2(AC.field2);      //Masked method with masked derived field
            
        }
    }
}
