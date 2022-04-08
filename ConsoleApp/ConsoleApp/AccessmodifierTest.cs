using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class AccessmodifierTest:InternalClass
    {
        public static void Main()
        {
            //InternalClass obj = new InternalClass();
            //obj.Test1();
            //obj.Test3();
            //obj.Test5();

            AccessmodifierTest obj = new AccessmodifierTest();
            obj.Test1();
            obj.Test3();
            obj.Test4();    
            obj.Test5();

        }
    }
}
