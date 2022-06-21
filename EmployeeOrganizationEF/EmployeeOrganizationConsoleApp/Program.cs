
using EmployeeOrganizationData.Entities;

using EmployeeOrganizationData;

namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {
            CURDEmployeeManager obj = new CURDEmployeeManager();
            Console.WriteLine("Adding a new Employee");
            obj.Insert(new Employee { Name = "Utkarsh", Address = "Gurgaon" });
            obj.Insert(new Employee { Name = "Abhimanyu", Address = "Delhi" });
            PrintAllEmployees();

            Console.WriteLine("Updating Employee with EmployeeId 2");
            obj.Update(2, new Employee { Name = "Modified Employee", Address = "Modified Address" });
            PrintAllEmployees();

            Console.WriteLine("Retrieving Employee details for EmployeeId 2");
            var employee = obj.GetEmplpoyeeById(2);
            Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");

            Console.WriteLine("Deleting Employee details for EmployeeId 2");
            obj.Delete(2);
            PrintAllEmployees();

            Console.ReadLine();

            SaveEmployee();
            Console.WriteLine("Done !!!");
            Console.ReadLine();
        }
        private static void PrintAllEmployees()
        {
            Console.WriteLine("Printing all Employees");
            CURDEmployeeManager obj = new CURDEmployeeManager();
            foreach (Employee employee in obj.GetAllEmployees())
            {
                Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
            }
        }
        private static void SaveEmployee()
        {
            CURDOrganizationManager obj = new CURDOrganizationManager();
            #region Save data in both the tables by Only Inserting in Education Table
            var employee = new Employee { Name = "Gopal", Address = "DURG" };
            List<Organization> organizations = new List<Organization>();
            organizations.Add(new Organization
            {
                Name = "Amazon",
                YearsOfWork = 3,
                Employees = employee
            });
            organizations.Add(new Organization
            {
                Name = "TCS",
                YearsOfWork = 2022,
                Employees = employee
            });

            obj.InsertOrganisation(organizations);
            #endregion

            #region Save data in both the tables by only Inserting in Employee Table
            //List<Organization> organizations = new List<Organization>();
            organizations.Add(new Organization { Name = "Amazon", YearsOfWork = 3 });
            organizations.Add(new Organization { Name = "TCS", YearsOfWork = 2 });

            obj.InsertEmployeeAndOrganization(new Employee { Name = "Ajeet", Address = "Mumbai" }, organizations);
            #endregion

            //List<Organization> organizations = new List<Organization>();
            organizations.Add(new Organization { Name = "Amazon", YearsOfWork = 3 });
            organizations.Add(new Organization { Name = "TCS", YearsOfWork = 2 });

            obj.InsertEmployeeAndOrganization(new Employee { Name = "Ajeet", Address = "Mumbai" }, organizations);
            obj.InsertOrganizationofExistingEmployee(3, organizations);

            obj.PrintEmployeeAndOrganization(3);
            Console.WriteLine("Done !!!");
            Console.ReadLine();
        }
    }
}


