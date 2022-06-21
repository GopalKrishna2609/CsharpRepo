using EmployeeOrganizationData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOrganizationData
{
    public class CURDOrganizationManager
    {
        DemoDBContext demoDbContext = new DemoDBContext();

        public void InsertOrganisation(List<Organization> organizations )
        {
            demoDbContext.Organizations.AddRange(organizations);
            demoDbContext.SaveChanges();
        }
        public void InsertEmployeeAndOrganization(Employee employee, List<Organization> organizations)
        {
            var objEmployee = new Employee
            {
                Name = employee.Name,
                Address = employee.Address,
                Organizations = organizations

            };

            demoDbContext.Employees.Add(objEmployee);
            demoDbContext.SaveChanges();
        }
        public void InsertOrganizationofExistingEmployee(int employeeID, List<Organization> organizations)
        {
            var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).Include(e => e.Organizations).First();

            objEmployee.Name = "Ajeet";

            // Do not write these 2 lines if you do not want to delete old records.
            objEmployee.Organizations.Clear();
            demoDbContext.SaveChanges();

            foreach (Organization organization in organizations)
            {
                objEmployee.Organizations.Add(organization);
            }

            demoDbContext.Employees.Update(objEmployee);
            demoDbContext.SaveChanges();
        }
        public void PrintEmployeeAndOrganization(int employeeID)
        {
            //var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).First();

            var objEmployee = demoDbContext.Employees.Where(x => x.ID == employeeID).Include(e => e.Organizations).First();

            Console.WriteLine($"Name of Employee is {objEmployee.Name}");

            foreach (Organization organization in objEmployee.Organizations)
            {
                Console.WriteLine($"Name of Course is {organization.Name}");
            }

        }
    }
}
