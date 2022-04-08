using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class StaticClassdemo
    {
        public static string ExtentionToStatic(this string s)
        { 
           return s.ToUpper();
        }

        public static void Main()
        {
            string s = "Hello developer,How are you?";
            s=s.ExtentionToStatic();
            Console.WriteLine(s);
        }
    }
}
