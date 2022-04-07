using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ObjectIntializerDemo
    {
        string Name, Email, Address;
        int Age, Salary;
        bool isActive;

        public static void Main()
        {
            ObjectIntializerDemo obj = new ObjectIntializerDemo()
            {
                Name = "Ranjeet Singh",
                Email = "sranjeet612@gmail.com",
                Address = "Bareilly",
                Age = 30,
                Salary = 5000,
                isActive = true
            };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Employee Details");
            sb.AppendLine($"Name:{obj.Name}");
            sb.AppendLine($"Email:{obj.Email}");
            sb.AppendLine($"Address:{obj.Address}");
            sb.AppendLine($"Age:{obj.Age}");
            sb.AppendLine($"Salary:{obj.Salary}");
            sb.AppendLine($"isActive:{obj.isActive}");

            Console.WriteLine(sb.ToString());

            Console.ReadLine(); 
        }

    }
}
