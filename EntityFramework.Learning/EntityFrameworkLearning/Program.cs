using EntityFramework.Data;
using EntityFramework.Data.Entities;

namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {

            //CRUDManager obj = new CRUDManager();

            //Console.WriteLine("Adding a new Employee");
            //obj.Insert(new Employee { Name = "Utkarsh", Address = "Gurgaon" });
            //obj.Insert(new Employee { Name = "Abhimanyu", Address = "Delhi" });
            //PrintAllEmployees();

            //Console.WriteLine("Updating Employee with EmployeeId 2");
            //obj.Update(2, new Employee { Name = "Modified Employee", Address = "Modified Address" });
            //PrintAllEmployees();

            //Console.WriteLine("Retrieving Employee details for EmployeeId 2");
            //var employee = obj.GetEmplpoyeeById(2);
            //Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");

            //Console.WriteLine("Deleting Employee details for EmployeeId 2");
            //obj.Delete(2);
            //PrintAllEmployees();

            //Console.ReadLine();

           // SaveEmployeeAndEducation();

            SaveClassRoomAndTeacher();

        }

        //private static void PrintAllEmployees()
        //{
        //    Console.WriteLine("Printing all Employees");
        //    CRUDManager obj = new CRUDManager();
        //    foreach (Employee employee in obj.GetAllEmployees())
        //    {
        //        Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
        //    }
        //}

        private static void SaveEmployeeAndEducation()
        {
            CURDeducationManager obj = new CURDeducationManager();
            //#region Save data in both the tables by Only Inserting in Education Table
            //var employee = new Employee { Name = "Gopal", Address = "DURG" };
            //List<EmployeeEducation> educationList = new List<EmployeeEducation>();
            //educationList.Add(new EmployeeEducation
            //{
            //    CourseName = "BTech",
            //    UniversityName = "DURG",
            //    MarksPercentage = 89,
            //    PassingYear = 2022,
            //    Employee = employee
            //});
            //educationList.Add(new EmployeeEducation
            //{
            //    CourseName = "MTech",
            //    UniversityName = "Delhi",
            //    MarksPercentage = 86,
            //    PassingYear = 2024,
            //    Employee = employee
            //});

            //obj.InsertEducation(educationList);
            //#endregion

            //#region Save data in both the tables by only Inserting in Employee Table
            //List<EmployeeEducation> educationList = new List<EmployeeEducation>();
            //educationList.Add(new EmployeeEducation { CourseName = "BBA", UniversityName = "Manipal", MarksPercentage = 80, PassingYear = 2020 });
            //educationList.Add(new EmployeeEducation { CourseName = "MBA", UniversityName = "Manipal", MarksPercentage = 75, PassingYear = 2022 });

            //obj.InsertEmployeeAndEducation(new Employee { Name = "Aditya", Address = "Hyderabad" }, educationList);
            //#endregion

            //#region updating Education of existing Employee by adding or clearing previous data
            //List<EmployeeEducation> educationList = new List<EmployeeEducation>();
            //educationList.Add(new EmployeeEducation { CourseName = "BCA", UniversityName = "Himachal", MarksPercentage = 80, PassingYear = 2020 });
            //educationList.Add(new EmployeeEducation { CourseName = "Mtech", UniversityName = "Bihar", MarksPercentage = 75, PassingYear = 2022 });

            //obj.InsertEducationofExistingEmployee(3, educationList);
            //#endregion
            //bj.PrintEmployeeAndEducation(2);


            Console.WriteLine("Done !!!");
            Console.ReadLine();
        }

        private static void SaveClassRoomAndTeacher()
        {
            CURDClassRoomAndTeacher obj = new CURDClassRoomAndTeacher();

            //obj.InsertTeacher(new Teachers { Name = "Utkarsh" });
            //obj.InsertClassRoom(new ClassRoom { Name = "Computer Science" });

            List<Teachers> teachers = new List<Teachers>();
            teachers.Add(new Teachers { Name = "Vidya"});
            teachers.Add(new Teachers { Name = "Shrijan" });


            obj.InsertClassRoomAndTeacher(new ClassRoom { Name = "Computer Science" },teachers);


            Console.WriteLine("Done !!!");
            Console.ReadLine();
        }
    }
}