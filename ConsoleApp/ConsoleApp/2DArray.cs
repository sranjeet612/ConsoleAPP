using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class TwodimentionalArray
    {
        public static void Main()
        {   
            //--first way to define the 2D-Array
            string[,] str = new string[3, 3];
            str[0, 0] = "Ranjeet";
            str[0, 1] = "Albert";
            str[0, 2] = "John";

            str[1, 0] = "Developer";
            str[1, 1] = "HR";
            str[1, 2] = "Manager";

            str[2, 0] = "Canada";
            str[2, 1] = "UK";
            str[2, 2] = "Singapore";

            //--Second way to define the 2D-Array

            string[,] str1 = { {"Ranjeet","Developer" },{"Albert","HR" },{"John","Manager" } };
            foreach (var item in str1)
            {
                Console.WriteLine(item);
               
            }
            
            Console.ReadLine();

        }

    }
}
