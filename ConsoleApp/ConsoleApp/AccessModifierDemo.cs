using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PublicClass
    {
        protected class ProtectedClass
        {
        }

        protected internal class ProtectedInternalClass
        {
        }

        private class PrivateClass
        {

        }
    }
    internal class InternalClass
    {
        public void Test1()
        {
            Console.WriteLine("Public Method of  InternalClass is called");
        }
        private void Test2()
        {
            Console.WriteLine("private Method of  InternalClass is called");
        }
        internal void Test3()
        {
            Console.WriteLine("internal Method of  InternalClass is called");
        }
        protected void Test4()
        {
            Console.WriteLine("protected Method of  InternalClass is called");
        }
        protected internal void Test5()
        {
            Console.WriteLine("protected-internal Method of  InternalClass is called");
        }
    }

   
}
