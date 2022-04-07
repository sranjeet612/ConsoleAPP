using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class InheritanceDemo: CircleArea
    {   
        public override void CircleTest()
        {
            Console.WriteLine("This is CircleTest method from InheritanceDemo class");
        }
        public static void Main()
        {
            CircleArea circle=new CircleArea();
            int area=circle.CalculateArea();
          

            SquareArea square=new SquareArea();
            int squar=square.CalculateArea();

            SealedClassdemo obj=new SealedClassdemo();
            obj.Test();

            Console.WriteLine($"Area of circle is :{area}");
            Console.WriteLine($"Area of Square is :{squar}");
        }
    }
}
