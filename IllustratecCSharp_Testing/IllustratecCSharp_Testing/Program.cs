using System;

namespace IllustratecCSharp_Testing
{
    public class WriteToConsole
    {
        //My changes don't seem to be pushing out to Github
        public void MyPrint()
        {
            Console.WriteLine($"My Print Class");
        }
    }

    class Program
    {
        //Learning new tricks, now for resharper
        static void Main(string[] args)
        {
            WriteToConsole MP = new WriteToConsole();
            MP.MyPrint();
        }
    }
}
