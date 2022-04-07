using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class LoopsDemo
    {
        public static void Main()
        {
            int x = 1;
            // while loop 
            while (x<=10)
            {
                Console.WriteLine($"the value of x is:{x}");
                x++;
            }

            // do while loop

            do
            {
                Console.WriteLine($"do while loop is running with value of x:{x}");
            } while (x<10);

            // for loop
            int y = 0;
            for (int z=10; y<10 && z<=10; y++,z--)
            {
                Console.WriteLine($"The value of y is :{y} and Z is:{z}");
            }

            Console.ReadLine();
        }
    }
}







