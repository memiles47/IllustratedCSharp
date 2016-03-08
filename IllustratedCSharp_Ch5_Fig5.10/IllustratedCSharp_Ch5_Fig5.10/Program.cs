using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp_Ch5_Fig5._10
{
    class MyClass { public int val = 20; }


    class Program
    {
        static void RefAsParameter(ref MyClass f1)
        {
            //Assign to the object member
            f1.val = 50;
            Console.WriteLine($"After member assignment:     {f1.val}");

            //Create a new object and assign it to the formal parameter
            f1 = new MyClass();
            Console.WriteLine($"After new object creation:   {f1.val}");
        }

        static void Main(string[] args)
        {
            MyClass a1 = new MyClass();

            Console.WriteLine($"Before method call:          {a1.val}");
            RefAsParameter(ref a1);
            Console.WriteLine($"After method Call:           {a1.val}");
        }
    }
}
