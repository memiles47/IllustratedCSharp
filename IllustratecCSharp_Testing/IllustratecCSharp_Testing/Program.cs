using System;

namespace IllustratecCSharp_Testing
{
    public class WriteToConsole
    {
        public void MyPrint()
        {
            Console.WriteLine($"My Print Class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteToConsole MP = new WriteToConsole();
            MP.MyPrint();
        }
    }
}
