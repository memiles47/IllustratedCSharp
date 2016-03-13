using System;

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
    //
    class OtherClass: SomeClass         //Derived class inheritance
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

        public void Method3(string value)
        {
            Console.WriteLine($"Derived class -- Base Accessed field2: {base.field2}");
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
            Console.WriteLine("\n*\n*\n");

            OC.Method2(OC.field1);      //Derived method with base field
            OC.Method2(OC.field2);      //Derived method with derived field
            Console.WriteLine("\n*\n*\n");

            //Inheritance with two classes, masking a field and a method
            AC.Method1(AC.field1);      //Base method with base field
            AC.Method2(AC.field2);      //Masked method with masked derived field
            AC.Method3("");
            Console.WriteLine("\n*\n*\n");


            SecondDerived Derived = new SecondDerived();    //Used SecondDerived
            MyBaseClass MyBC =  (MyBaseClass)Derived;       //Use MyBaseClas
            MyDerivedClass myDerived = new MyDerivedClass();//Used MyDerivedClass

            Derived.Print();
            MyBC.Print();
            Console.WriteLine("\n*\n*\n");

            Console.WriteLine($"myDerived.myProperty = {myDerived.myProperty}");
            Console.WriteLine($"MyBC.myProperty = {MyBC.myProperty}");
            Console.WriteLine("\n*\n*\n");
        }
    }
}
