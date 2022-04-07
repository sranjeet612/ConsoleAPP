using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class CircleArea : Area
    {   
      
        public sealed override int CalculateArea()
        {
            Hight = Lenth = Width = 10;
            return Hight * Lenth * Width;
        }
        public virtual void CircleTest()
        {
            Console.WriteLine("This is CircleTest method from CircleArea class");
        }
    }
}
