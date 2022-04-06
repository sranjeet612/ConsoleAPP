using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ReverseArray
    {
        public static void Main()
        {
            ReverseString();
            ReverseArr();
        }
        static void ReverseArr()
        {
            int[] arr = new int[] { 4, 6, 8, 3, 2, 4, 5, 7 };
            List<int> list = new List<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int j = arr[i];
                list.Add(j);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void ReverseString()
        {
            string str = "Ranjeet";
            string result=string.Empty;
            for (int i = str.Length-1; i >=0; i--)
            {
                char j=str[i];
                result+=j;
            }
            Console.WriteLine(result);
        }
    }
}
