using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class StackDemo
    {
        public static void Main()
        {   
            //----Stack demo 
            Stack<string> stack = new Stack<string>();
            stack.Push("Ranjeet Singh");
            stack.Push("Albert");
            stack.Push("John");
            stack.Push("Scott");
            stack.Push("Peter");

            while (stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("----Queue-----");
            //---- Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Apple");
            queue.Enqueue("Mango");
            queue.Enqueue("Banana");
            queue.Enqueue("Grepps");
            queue.Enqueue("PineApple");
            queue.Enqueue("Orange");
            while (queue.Count>0)
            {
                Console.WriteLine(queue.Dequeue());
            } 
            Console.ReadLine(); 
        }
    }
}











