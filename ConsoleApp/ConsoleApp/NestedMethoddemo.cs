using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class NestedMethoddemo
    {   
        private void Countdown()
        {
            int x = 10;
            recursion(x);
            Console.WriteLine("Done!");
            void recursion(int x)
            {
                if (x <= 0) return;
                System.Console.WriteLine($"The Value of x is :{x}");
                System.Threading.Thread.Sleep(1000); // wait 1 second
                recursion(x - 1);
            }
        }
        public static void Main()
        {
            NestedMethoddemo obj=new NestedMethoddemo();
            obj.Countdown();
        }
    }
}
