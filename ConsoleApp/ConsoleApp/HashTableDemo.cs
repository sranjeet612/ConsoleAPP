using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class HashTableDemo
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 5000);
            ht.Add("string", "Ranjeet");
            ht.Add("Bool", true);
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"keys:{item.Key}, Values:{item.Value}");
            }

            Console.WriteLine("==========================================");
            //---Second ay to define Hash Table

            Hashtable ht1 = new Hashtable() {
                {"Cities","Bareilly,Agra,Lucknow,Mumbai"},
                {1,"USA,India,UK,Germany"},
                {"fruit","Mango,Apple,Orange,Banana"}
            };

            foreach (DictionaryEntry item in ht1)
            {
                Console.WriteLine($"Key:{item.Key}, Values: {item.Value}");
            }
            Console.ReadLine();
        }
    }
}







