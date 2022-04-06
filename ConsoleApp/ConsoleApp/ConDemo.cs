using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ConDemo
    {
        public ConDemo()
        {
            Console.WriteLine("parameter less constructor is called:");
        }
        public ConDemo(string s)
        {
            Console.WriteLine($"Parameterised constructor is called:{s}");
        }
        static ConDemo()
        {
            Console.WriteLine("static constructor is called.");
        }
        public static void Main()
        {
            ConDemo demo = new ConDemo("Hello .Net Core Developer");
            MathOperation obj = new MathOperation();
            obj.PrePostincreament();
        }


    }
}
