using EntityFramework.Data;
using EntityFramework.Data.Entities;

namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {
            CRUDManager obj = new CRUDManager();
            //#region Employee
            //Console.WriteLine("Adding a new Employee");
            //obj.Insert(new Employee { Name = "Krishna", Address = "Durg" });
            //obj.Insert(new Employee { Name = "Ajay", Address = "Bombay" });
            //PrintAllEmployees();

            //Console.WriteLine("Updating Employee with EmployeeId 7");
            //obj.Update(7, new Employee { Name = "Modified Employee", Address = "Modified Address" });
            //PrintAllEmployees();

            //Console.WriteLine("Retrieving Employee details for EmployeeId 7");
            //var employee = obj.GetEmplpoyeeById(7);
            //Console.WriteLine($"Employee Name of employee ID 7 is {employee.Name}");

            //Console.WriteLine("Deleting Employee details for EmployeeId 7");
            //obj.Delete(7);
            //PrintAllEmployees();
            //#endregion

            #region EmployeeEducation

            Console.WriteLine("Adding a new Employee Education");
            obj.Insert(new EmployeeEducation { CourseName = "Bcom", UniversityName = "ITUT", PassingYear = 2022, MarksPercentage = 96 });
            obj.Insert(new EmployeeEducation { CourseName = "MCA", UniversityName = "CSVTU", PassingYear = 2020, MarksPercentage = 97 });
            PrintAllEmployeeEducation();

            Console.WriteLine("Updating Employee Education with ID 5");
            obj.Update(5, new EmployeeEducation { CourseName = "Modified CourseName", UniversityName = "Modified UniversityName", PassingYear = 0000, MarksPercentage = 00 });
            PrintAllEmployeeEducation();


            Console.WriteLine("Retrieving Employee Education details for ID 5");
            var employeeEducation = obj.GetEmplpoyeeEducationById(5);
            Console.WriteLine($"Employee Name of  ID 1 is {employeeEducation.ID}");

            Console.WriteLine("Deleting Employee Education details for ID 5");
            obj.DeleteEmpEdu(5);
            PrintAllEmployeeEducation();

            #endregion

            Console.ReadLine();
        }


        private static void PrintAllEmployees()
        {
            Console.WriteLine("Printing all Employees");
            CRUDManager obj = new CRUDManager();
            foreach (Employee employee in obj.GetAllEmployees())
            {
                Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
            }
        }
        private static void PrintAllEmployeeEducation()
        {
            Console.WriteLine("Printing all Employees");
            CRUDManager obj = new CRUDManager();
            foreach (EmployeeEducation empEdu in obj.GetAllEmployeeEducation())
            {
                Console.WriteLine($"ID = {empEdu.ID} Cource Name = {empEdu.CourseName} UniversityName = {empEdu.UniversityName} PassingYear = {empEdu.PassingYear} MarksPercentage = {empEdu.MarksPercentage} ");
            }
        }
    }
}