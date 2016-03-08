﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllustratedCSharp_CodeTesting
{
    class X
    {
        public const double pi = 3.14159;
    }

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

    class Program
    {
        static void Main(string[] args)
        {
            //Create two instances of class D
            D d1 = new D();
            D d2 = new D();

            d1.SetVars(2, 4);
            d1.Display("d1");

            d2.SetVars(15, 17);
            d2.Display("d2");

            d1.Display("d1");

            Console.WriteLine($"Pi = {X.pi}");
        }
    }
}