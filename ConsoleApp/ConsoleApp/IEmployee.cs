using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IEmployee
    {
        IEmployee GetEmployee();
        void SaveEmployee();
        void UpdateEmployee();
        void DeleteEmployee();


    }
}
