using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (!string.IsNullOrEmpty(s))
            {
                ReverseString.ReverseInputString(s);
            }

            Console.WriteLine("My first .Net Core Console Application!!!");
        }
    }
}
