using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DelegatesDemo
    {
        public delegate void Mydel(string s);
        public delegate void Mydel2(int x);
        public delegate void Mydel3();

        public static void Main()
        {   
            DelegatesDemo demo = new DelegatesDemo();   
            Mydel obj = new Mydel(demo.Test);
            obj+=demo.Test1;
            obj("Ranjeet Singh");
            obj.Invoke("Software Engineer");
           
            Mydel mydel = delegate (string s)
            {

                Console.WriteLine(s.ToUpper());
            };

            mydel.Invoke("This is Anonymous Method");

            Mydel2 del=(int x)=>Console.WriteLine($"This is Anonymous Method with lembda Expression.{x}");
            del(100);

            Mydel3 mydel3 = () =>
            {
                Console.WriteLine($"This is Anonymous method without Parameter.");
            };
            mydel3();
            Console.ReadLine();
        }

        public void Test(string s)
        {
          Console.WriteLine($"Test method is called via delegates:{s}");
        }
        public void Test1(string s)
        {
            Console.WriteLine($"Test1 method is called via delegates:{s}");
        }
    }
}
