using System;

namespace IllustratedCSharp_Ch5_Fig5._12
{
    class MyClass
    {
        public void ListInts(params int[] intVals)
        {
            if (intVals != null && (intVals.Length != 0))
            {
                for (int i = 0; i < intVals.Length; i++)      //Process the array
                {
                    intVals[i] *= 10;
                    Console.WriteLine($"{intVals[i]}");       //Display new values
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int first = 5; int second = 6; int third = 7;     //Declare three ints
            int[] myArr = new int[] { 7, 8, 9 };

            MyClass mc = new MyClass();                       //Create new MyClass object
            mc.ListInts(first, second, third);                //Call the method
            mc.ListInts(myArr);

            Console.WriteLine($"{first}, {second}, {third}"); //Display 
            foreach (int x in myArr)
            {
                Console.WriteLine($"{x}");                    //Display each element
            }
        }
    }
}
