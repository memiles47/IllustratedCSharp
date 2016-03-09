using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp_CodeTesting
{
    #region Class X, Constants
    class X
    {
        public const double pi = 3.14159;
    }
    #endregion

    #region Class D, Static members
    class D
    {
        int mem1;
        static int mem2;

        //Set the values
        public void SetVars(int v1, int v2)
        {
            mem1 = v1;
            mem2 = v2;
        }

        //Display variables
        public void Display(string str)
        {
            Console.WriteLine($"{str}: mem1 = {mem1}, mem2 = {mem2}");
        }
    }
    #endregion

    #region Class C1, properties
    class C1
    {
        private int theRealValue = 10;          //Backing Field memory allocated (Camel Casing)
        public int TheRealValue                  //Property, no memory allocated (Pascal Casing)
        {
            set
            {
                theRealValue = value;           //Sets the value of field theRealValue
            }
            get
            {
                return theRealValue;            //Gets the value of the field theRealValue
            }
        }
    }
    #endregion

    #region Class1, Indexers
    class Class1
    {
        int temp0;                          //Private field
        int temp1;                          //Private field

        public int this[int index]
        {
            get                             //Return value of either temp0 or temp1
            {
                return index == 0 ? temp0 : temp1;
            }
            set
            {
                if (index == 0)
                {
                    temp0 = value;
                }
                else
                {
                    temp1 = value;
                }
            }
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //Class D
            //Create two instances of class D
            D d1 = new D();
            D d2 = new D();

            d1.SetVars(2, 4);
            d1.Display("d1");

            d2.SetVars(15, 17);
            d2.Display("d2");

            d1.Display("d1");

            //Class X
            Console.WriteLine($"Pi = {X.pi}\n\n");

            //Class C1
            C1 c = new C1();
            Console.WriteLine($"myValue:    {c.TheRealValue}");

            c.TheRealValue = 20;
            Console.WriteLine($"myValue:    {c.TheRealValue}\n\n");

            //class Class1
            Class1 a = new Class1();
            Console.WriteLine($"Values -- T0: {a[0]}, T1: {a[1]}");

            a[0] = 15; a[1] = 20;

            Console.WriteLine($"Values -- T0: {a[0]}, T1: {a[1]}");
        }
    }
}
