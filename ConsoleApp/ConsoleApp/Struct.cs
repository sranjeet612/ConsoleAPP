using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    struct myStruct
    {
        public static int x = 10;
        public const int y = 20;
        string Name;
        string Email;
        myStruct (string name,string email )
        { 
            this.Name = name;
            this.Email = email;
        }
    }
}
