using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class AsynchronousDemo
    {

        private async void Test()
        {
            Console.WriteLine("Async method is started.");
            await Task.Delay(1000);
            Console.WriteLine("Async method is completed.");
        }
        public static void Main()
        {
            Console.WriteLine("Main Method is started....");
            new AsynchronousDemo().Test();
            new AsynchronousDemo().Test3();  
            Console.WriteLine("Main Method is Completed....");
            Console.ReadLine();
        }

        Task<string> Test2()
        {
            return Task.Run<string>(() =>
            {
                Thread.Sleep(1000);
                return "Running Task method with Lembda Expression";
            });
        }

        async void Test3()
        {
            string result = await Test2();
            Console.WriteLine(result);
        }

    }
}
