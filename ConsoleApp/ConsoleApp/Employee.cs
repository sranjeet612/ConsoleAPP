using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Employee : IEmployee
    {
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        double Salary { get; set; }

        enum DayList
        {
            monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public IEmployee GetEmployee()
        {
            Employee employee = new Employee()
            {
                Name = "Ranjeet Singh",
                Email = "sranjeet612@gmail.com",
                Address = "Hyderabad",
                Salary = 5000
            };
            return employee;
        }

        public void SaveEmployee()
        {    
            throw new NotImplementedException();
        }

        public void UpdateEmployee()
        {
        }

        public static void Main()
        {
            try
            {
                Employee obj = new Employee();
                IEmployee data = obj.GetEmployee();
                Console.WriteLine(data);
                Console.ReadLine();

              
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException Block is Executed.");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("OutOfMemoryException Block is Executed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception ex:{ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally Block is Executed.");
            }
        }
    }
}
