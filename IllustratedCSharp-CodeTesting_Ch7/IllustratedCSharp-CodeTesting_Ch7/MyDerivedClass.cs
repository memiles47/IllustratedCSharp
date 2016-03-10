using System;

namespace IllustratedCSharp_CodeTesting_Ch7
{
    class MyDerivedClass : MyBaseClass
    {
        public override void Print()
        {
            Console.WriteLine("This is the derived class.");
        }
    }
}
