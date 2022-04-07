using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Ternarydemo
    {
        public static void Main()
        {
            int x=new System.Random().Next(-10,10);
            string result=(x < 0) ? "x is negative" : "x is positive";
            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
}
