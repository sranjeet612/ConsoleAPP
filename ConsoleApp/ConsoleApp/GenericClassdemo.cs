using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class GenericClassdemo
    {
        public static void Main()
        {   
            //--first way to dedefine arraylist
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Ranjeet Singh");
            arrayList.Add(3.14F);
            arrayList.Add(50.005M);
            arrayList.Add(new int[] {1,2,3,4,5,6,7,8,9 });
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //--Second way to define ArrayList
            ArrayList arrayList1 = new ArrayList() { 
            "Ranjeet Singh",
              50000,
              42.5F,
              true,
              new String[] {"software Developer","ranjeet@gmial.com","123","Hyderabad","India"}
            };

            foreach (var item in arrayList1)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
