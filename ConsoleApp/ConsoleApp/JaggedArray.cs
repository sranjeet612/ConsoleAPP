using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class JaggedArray
    {
        public static void Main()
        {   
            //--first way to defind Jagged-array
            string[][] arr=new string[2][];
            arr[0]=new string[2];
            arr[1] = new string[3];

            arr[0][0] = "Ranjeet";
            arr[0][1] = "Developer";
            arr[1][0] = "John";
            arr[1][1] = "Albert";
            arr[1][2] = "Peter";

            foreach (var item in arr)
            {
                foreach (var t in item)
                {
                    Console.WriteLine(t);
                }   
            }
            //---second way

            string[][] arr2 = { new string[] { "Hello","Hi","Namaste" },new string[] {"Ram","Shyam","Mohan","Sohan" } };
            foreach (var item in arr2)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
