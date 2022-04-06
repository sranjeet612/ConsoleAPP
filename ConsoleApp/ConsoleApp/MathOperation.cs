using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MathOperation
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int div(int x, int y) 
        {
            return x / y;
        }

        public int Mod(int x, int y)
        {
            return x % y;
        }

        public void PrePostincreament()
        {
            int x = 5, y =0;
            y = x++;
            Console.WriteLine($"Value of Y:{y}, and X:{x} using post increment operator");
            y = 0; x=5;
            y = ++x;
            Console.WriteLine($"Values of Y:{y} and X:{x} using preIncreament operator");
        }

    }
}











