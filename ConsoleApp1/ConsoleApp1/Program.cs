using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        private int empId;
        private string empname;
        public Employee(int _empId, string _empname)
        {
            empId = _empId;
            empname = _empname;

        }
        public void Showdetails()
        {
            Console.WriteLine("employee Id:", +empId);
            Console.WriteLine("employee Name:", empname);
        }
        

        class Program
        {
            static void Main(string[] args)
            {
                Employee empl = new Employee(101, "Abd");
                empl.Showdetails();
                Console.ReadLine();
            }
        }
    }
}
