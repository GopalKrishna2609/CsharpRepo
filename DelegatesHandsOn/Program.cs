using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            List<Employee> emp = new List<Employee>
           {
                 new Employee{ Id = 101, Name = "Ravi", Salary = 20000, Experiance = 3 },
                 new Employee{ Id = 102, Name = "John", Salary = 30000, Experiance = 5 },
                 new Employee{ Id = 103, Name = "Mary", Salary = 50000, Experiance = 8 },
                 new Employee{ Id = 104, Name = "Mike", Salary = 40000, Experiance = 2 },
           };

            //1: Delegate object
            Employee.isPromote isPromoted = new Employee.isPromote(Employee.promote);//passing method reference of promote method

            isPromoted += new Employee.isPromote(Employee.promoteBySal);//passing method reference of promoteBySal method

        }
    }
}