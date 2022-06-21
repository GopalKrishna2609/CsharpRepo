using EntityFramework.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public class CURDeducationManager
    {
        DemoDbContext demoDbContext = new DemoDbContext();

        public void InsertEducation(List<EmployeeEducation> educationList)
        {
            demoDbContext.EmployeeEducations.AddRange(educationList);
            demoDbContext.SaveChanges();
        }

        public void InsertEmployeeAndEducation(Employee employee, List<EmployeeEducation> educationList)
        {
            var objEmployee = new Employee
            {
                Name = employee.Name,
                Address = employee.Address,
                EducationList = educationList

            };

            demoDbContext.Employees.Add(objEmployee);
            demoDbContext.SaveChanges();
        }

        public void InsertEducationofExistingEmployee(int employeeID, List<EmployeeEducation> educationList)
        {
            var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).Include(e => e.EducationList).First();

            objEmployee.Name = "Aditya";

            // Do not write these 2 lines if you do not want to delete old records.
            objEmployee.EducationList.Clear();
            demoDbContext.SaveChanges();

            foreach (EmployeeEducation education in educationList)
            {
                objEmployee.EducationList.Add(education);
            }

            demoDbContext.Employees.Update(objEmployee);
            demoDbContext.SaveChanges();
        }

        public void PrintEmployeeAndEducation(int employeeID)
        {
            //var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).First();

            var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).Include(e => e.EducationList).First();

            Console.WriteLine($"Name of Employee is {objEmployee.Name}");

            foreach (EmployeeEducation education in objEmployee.EducationList)
            {
                Console.WriteLine($"Name of Course is {education.CourseName}");
            }

        }
    }
}
