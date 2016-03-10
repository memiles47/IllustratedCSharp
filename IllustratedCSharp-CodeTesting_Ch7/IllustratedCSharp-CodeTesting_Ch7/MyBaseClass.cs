using System;

namespace IllustratedCSharp_CodeTesting_Ch7
{
    class MyBaseClass
    {
        //Private field of MyBaseClass
        private int _myInt = 5;

        //virtual property of MyBaseClass accessing the private field
        virtual public int myProperty
        {
            get
            {
                return _myInt;
            }
        }

        virtual public void Print()
        {
            Console.WriteLine("This is the base class.");
        }
    }
}
