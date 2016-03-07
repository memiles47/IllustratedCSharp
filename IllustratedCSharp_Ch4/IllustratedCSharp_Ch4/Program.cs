using System;

/*
Illustrated C# code from chapter 4 illustrating the declaration
of a class, public instance fields. Creating two instances of the
same class and initializing the fields within those class instances.

Then accessing those same fields and method and then print to the
console
*/

namespace IllustratedCSharp_Ch4
{
    class DaysTemp                              //Declare the class
    {
        public int high, low;                   //Declare the instance fields

        public int average()                    //Declare a method
        {
            return (high + low) / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Create two instances of DaysTemp
            DaysTemp T1 = new DaysTemp();       //Both object creations are syntactically the same
            var T2 = new DaysTemp();            //as the DaysTemp class can be inferred in the second.

            //Write to the fields of each instance
            T1.high = 76;   T1.low = 57;
            T2.high = 75;   T2.low = 53;

            //Read from the fields of each instance and call a method of
            //each instance
            Console.WriteLine($"T1: {T1.high}, {T1.low}, {T1.average()}");
            Console.WriteLine($"T2: {T2.high}, {T2.low}, {T2.average()}");
        }
    }
}
