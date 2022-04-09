using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DictionaryDemo
    {
        public static void Main()
        { 
            Dictionary<string,string> dic=new Dictionary<string, string>();
            dic.Add("fruit", "mango,apple,orange,banana");
            dic.Add("Course", "Asp.Net MVC,.Net Core,Angular,Azure");
            dic.Add("Cities", "Hyd,delhi,mumbai,goa,chennai");
            dic.Add("Country", "India,Uk,USA,Canada,Germany");
            string result;
            dic.TryGetValue("Country", out result);
            Console.WriteLine("Result:"+result);


            foreach (var item in dic)
            {
                Console.WriteLine($"Key:{item.Key},  Values:{item.Value}");
            }
            Console.ReadLine(); 
        }
    }
}
