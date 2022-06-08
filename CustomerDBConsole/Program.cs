using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDBConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Select one of the Options :\n");
            Console.WriteLine("\t\tPress 1 For Customer Data");
            Console.WriteLine("\t\tPress 2 For Employee Data");
            Console.WriteLine("\t\tPress 3 For Account Data");
            // Console.WriteLine("\t\tPress 4 To Show All Information in the table");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CustomerData customerData = new CustomerData();
                    string result = customerData.InsertCust();
                    Console.WriteLine(result);
                    break;
                case 2:
                    EmployeeData employeeData = new EmployeeData();
                    string result1 = employeeData.InsertEmp();
                    Console.WriteLine(result1);
                    break;
                case 3:
                    AccountData accountData = new AccountData();
                    string result2 = accountData.InsertAccount();
                    Console.WriteLine(result2);
                    break;
                case 4:
                    break;
            }

        }
    }
}
