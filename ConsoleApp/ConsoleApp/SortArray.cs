using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SortArray
    {
        public static void Main()
        {
            int[] arr = new int[] { 100,20,55,33,66,89,34,4, 2, 3, 6, 7, 99, 234, 65, 34, 88 };
            SortMethod(arr);
        }

        static void SortMethod(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
