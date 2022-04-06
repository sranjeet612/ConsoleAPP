using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ArrayDemo
    {
        public static void Main()
        {  
            // first-way to declare array
            int[] arr;
            arr = new int[3];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;    
            Console.WriteLine(arr[0]+arr[1]+arr[2]);

            // second way to define array
            int[] arr1=new int[] {10,20,30,40,50};
            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }

            // third way to defind array

            int[] arr3 = {1,2,3,4,55,6,6,7};
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            } 

            Console.ReadLine();
        }
    }
}
