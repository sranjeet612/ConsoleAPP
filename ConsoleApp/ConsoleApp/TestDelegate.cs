using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class TestDelegate
    {
        delegate void Printer();
        static void Main()
        {
            List<Printer> printers = new List<Printer>();
            int i = 0;
            for (; i < 10; i++)
            {
                printers.Add(()=>{ Console.WriteLine(i); });
            }
            foreach (var printer in printers)
            {
                printer();
            }
        }
    }
}
