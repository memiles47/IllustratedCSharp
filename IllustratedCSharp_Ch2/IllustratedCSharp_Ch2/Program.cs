using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp_Ch2
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 3;
            int var2 = 6;

            //CSharp 5.0 text formating (This is compatible in 6.0 as well)
            Console.WriteLine("This is variable one: {0}, This is variable two: {1}", var1, var2);

            //Charp 6.0 text formating (backward compatible of course), my perfered method.
            //Note: there is a slight difference in line length which all adds up
            Console.WriteLine($"This is variable one: {var1}, This is variable two: {var2}");
            Console.WriteLine("\nBoth versions produce the same results");
        }
    }
}
