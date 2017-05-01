using System;

namespace IllustratedCSharp__Ch5_Fig5._9
{

    class MyClass { public int val = 20; }


    class Program
        //The program still runs!
    {
        static void RefAsParameter(MyClass f1)
        {
            f1.val = 50;
            Console.WriteLine($"After member assignment:     {f1.val}");
            f1 = new MyClass();
            Console.WriteLine($"After new object creation:   {f1.val}");
        }

        static void Main(string[] args)
        {
            MyClass a1 = new MyClass();

            Console.WriteLine($"Before method call:          {a1.val}");
            RefAsParameter(a1);
            Console.WriteLine($"After method Call:           {a1.val}");
        }
    }
}
