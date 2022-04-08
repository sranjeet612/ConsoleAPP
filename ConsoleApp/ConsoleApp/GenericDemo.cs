using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class GenericDemo
    {
        const string Name = "Generic Class Demo";
        readonly string Email;
        readonly string Password;

        public GenericDemo()
        {
            this.Email = "sranjeet612@gmail.com";
            this.Password = "123";
        }
        public static void Main()
        {   
            GenericDemo demo = new GenericDemo();
            demo.Swap(10, 20);
            demo.Swap<string>("Ranjeet", "Singh");
            demo.Swap<bool>(true,false);
          
            Console.WriteLine(GenericDemo.Name);
        }

        public void Swap(int a, int b)
        {
            Console.WriteLine($"The Value of a is:{a} and b is{b}");
            int Temp = a;
            a = b;
            b = Temp;

            Console.WriteLine($"The Value of a is:{a} and b is{b}");

        }

        //-Generic method

        public void Swap<T>(T x, T y)
        {
            Console.WriteLine($"The value of x:{x} and y:{y}");
            T temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"The value of x:{x} and y:{y}");
        }
    }

    public class GenericClassDemo<T>
    {
        public T Add<T>(T x, T y)
        {
            return x;
        } 
    }
}





