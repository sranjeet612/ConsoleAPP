using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ListDemo
    {
        public static void Main()
        {   
            //---First way to declare the list
            List<string> list = new List<string>();
            list.Add("Asp.Net mvc");
            list.Add("Asp.Net WebApi");
            list.Add("Asp.Net Webform");
            list.Add("C#");
            list.Add("Azure");
            list.Add("Angular");
            list.Insert(0, ".Net Core5 with Azure");
            list.Remove("Asp.Net Webform");
            var result=from s in list select s;
            Console.WriteLine(result.Count());
            Console.WriteLine(result.First());
           
            Console.WriteLine("----------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //--Second way to define the List
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
           
            list1.ForEach(x => Console.WriteLine(x));   
            Console.ReadLine();
        }
    }
}
