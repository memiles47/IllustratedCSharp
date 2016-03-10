using System;

namespace IllustratedCSharp_CodeTesting_Ch7
{
    class MyDerivedClass : MyBaseClass
    {
        private int _myInt = 10;
        public override int myProperty
        {
            get
            {
                return _myInt;
            }
        }

        public override void Print()
        {
            Console.WriteLine("This is the derived class.");
        }
    }
}
