using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SwitchexpressionDemo
    {
        public static void Main()
        { 
            int x =new System.Random().Next(4);
            string result = x switch
            {
                0 => "zero",
                1 => "one",
                _ => "more than one"
            };

            Console.WriteLine(result);
            Console.ReadLine();

            string[] arrStr = {"Asp.net","MVC","c#","Blazor","Azure","Angular" };
            foreach (var item in arrStr)
            {
                string finalresult = item switch
                {
                    "Asp.net" => "This is Asp.net web Project",
                    "MVC" => "This is Asp.net MVC Project",
                    "c#" => "This is c# Project",
                    "Blazor" => "This is Blazor Project",
                    "Azure" => "This is Azure Project",
                    "Angular" => "This is Angular Project",
                    _=> "This Project is not Defined "
                };
                Console.WriteLine(finalresult);
                Console.ReadLine();
            }
            

        }
    }
}
