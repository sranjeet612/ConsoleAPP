using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class SquareArea : Area
    {
        public override int CalculateArea()
        {
            Hight = 10;
            Width = 20;
            return Hight * Width;
        }
    }
}
