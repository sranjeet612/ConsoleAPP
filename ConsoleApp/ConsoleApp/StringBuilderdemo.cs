using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class StringBuilderdemo
    {
        public static void Main()
        {
            string s = "Hello";
            s=s.Replace('e','a');
            Console.WriteLine(s);
            s=s.Insert(0, "My");
            Console.WriteLine(s);
            s=s.Remove(0,2);
            Console.WriteLine(s);

            StringBuilder sb=new StringBuilder();
            sb.Append("Hi");
            sb.AppendLine();
            sb.Append("Developers"); 
            s=sb.ToString();
            Console.WriteLine(s);
        }
    }
}
