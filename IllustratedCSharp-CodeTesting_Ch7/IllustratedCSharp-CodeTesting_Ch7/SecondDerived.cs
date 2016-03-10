using System;

namespace IllustratedCSharp_CodeTesting_Ch7
{
    class SecondDerived : MyDerivedClass
    {
        new public void  Print()
        {
            Console.WriteLine("This is the second derived class.");
        }
    }
}
