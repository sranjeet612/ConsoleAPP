using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DelDemo
    {   
        public static void Main()
        {
            DelDemo obj = new DelDemo();
            Console.WriteLine(obj.func("Ranjeet Singh"));
            Console.WriteLine(obj.func2(10,20));
        }

        Func<string, string> func = (s) =>
        {
            return s.ToUpper();
        };

        Func<int, int, int> func2 = (x, y) =>
         {
             return x + y;
         };

    }
}
