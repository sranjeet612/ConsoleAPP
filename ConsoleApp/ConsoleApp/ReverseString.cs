using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ReverseString
    {
        public static void ReverseInputString(string s)
        {
            //string s = "Hellow Word";
            string[] arr = s.Split(' ');
            string finalresult = string.Empty;
            foreach (string item in arr)
            {
                string reverse = string.Empty;
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    char r = item[i];
                    reverse += r;
                }
                finalresult += reverse;
            }
            Console.WriteLine(finalresult);
        }
    }
}
