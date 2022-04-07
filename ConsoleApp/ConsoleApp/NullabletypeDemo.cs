using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable
namespace ConsoleApp
{
    // This class using #nullable enable directive so in this class null values can be assigned to only nullable type variables 
    class NullabletypeDemo
    {
        public static void Main()
        {
            string? s =null;
            int? i = null; 
            string s1 = "";
            int length=s1.Length;
            Console.WriteLine(length);

            string result=s ?? "This is null string";
            i = i ??= 100;
            Console.WriteLine($"the Value of I is :{i}");   
            Console.WriteLine(result);

            int? j = null;
            j = s?.Length;
            Console.WriteLine($"the Value of J is :{j}");

            Console.ReadLine();
        }
    }
}
