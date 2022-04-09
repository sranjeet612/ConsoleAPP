using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SortedListDemo
    {
        public static void Main()
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(2, "Mango");
            list.Add(3, "Orange");
            list.Add(4, "Papaya");
            list.Add(1, "Apple");
            list.Add(5, "Guava");

            var result=from s in list select s;
            Console.WriteLine(result.Count());
            Console.WriteLine(result.First().Value);
            Console.WriteLine(result.Last().Value);
            Console.WriteLine("----------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine($"Key:{item.Key},Values:{item.Value}");
            }

            //---Second way to define SortedList

            SortedList<string, string> keyValuePairs = new SortedList<string, string> {
                {"Uttar Pradesh","India" },
                {"London","UK" },
                {"Alberta","Canada" },
                {"vuhan","China" },
                {"Washington-DC","USA" }
            };

            foreach (KeyValuePair<string,string> item in keyValuePairs)
            {
                Console.WriteLine($"key: {item.Key}, value: {item.Value}");
            }
            Console.ReadLine();

        }
    }
}
     






