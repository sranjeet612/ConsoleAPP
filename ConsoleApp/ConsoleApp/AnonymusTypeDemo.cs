using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class AnonymusTypeDemo
    {
        public static void Main()
        {
            var obj = new { Name="Ranjeet",Email="sranjeet612@gmail.com",Address="Hyderabad",Salary=5000};
            Console.WriteLine($"Name:{obj.Name}");
            Console.WriteLine($"Email:{obj.Email}");
            Console.WriteLine($"Address:{obj.Address}");
            Console.WriteLine($"Salary:{obj.Salary}");
        }
    }
}
