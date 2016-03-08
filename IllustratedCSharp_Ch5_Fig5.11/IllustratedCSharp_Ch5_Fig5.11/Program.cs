using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp_Ch5_Fig5._11
{
    //Declare MyClass class and instantiate the field val to 20
    class MyClass { public int val = 20; }


    class Program
    {
        static void MyMethod(out MyClass f1, out int f2)
        {
            f1 = new MyClass();                 //Create an object of the class
            f1.val = 25;                        //Assign 25 to the class field
            f2 = 15;                            //Assign 15 to the int parameter
        }
        static void Main(string[] args)
        {
            MyClass a1 = null;                  //
            int a2;

            MyMethod(out a1, out a2);           //Call the method

            //Print contents of at.val and a2 to console
            Console.WriteLine($"The out values are, a1.val = {a1.val}, a2 = {a2}");
        }
    }
}
