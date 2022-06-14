using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDBConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
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
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress a to Insert Data.");
                    Console.WriteLine("\t\tPress b to Update Data.");
                    Console.WriteLine("\t\tPress c to Delete Data.");
                    Console.WriteLine("\t\tPress d to Show All Customer Table Data.");
                    Console.WriteLine("\t\tPress e to Show a Perticular Customer Data.");

                    string choice1 = Console.ReadLine();
                    switch (choice1)
                    {
                        case "a":
                            string result = customerData.InsertCust();
                            Console.WriteLine(result);
                            break;
                        case "b":
                            result = customerData.UpdateCust();
                            Console.WriteLine(result);
                            break;
                        case "c":
                            Console.WriteLine("\nEnter The Customer ID to Delete :");
                            int CustID = Convert.ToInt32(Console.ReadLine());   
                            result = customerData.DeleteCust(CustID);
                            Console.WriteLine(result);
                            break;
                        case "d":
                            Console.WriteLine();
                            dt = customerData.SelectCust();
                            if(dt.Rows.Count == 0)
                            {
                                Console.WriteLine("NO DATA FOUND");
                            }
                            for(int i = 0 ; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;
                        case "e":
                            Console.WriteLine("Enter The Customer ID To See Its Details : ");
                           int SearchID = Convert.ToInt32( Console.ReadLine());
                            dt = customerData.SelectCustID();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                // int ID = (int)dt.Rows[i][0];
                                if ((int)dt.Rows[i][0] == SearchID)
                                {
                                    {
                                        for (int j = 0; j < dt.Columns.Count; j++)
                                        {

                                            Console.Write(dt.Rows[i][j] + "\t\t");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;

                    }

                    break;
                case 2:
                    EmployeeData employeeData = new EmployeeData();

                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress a to Insert Data.");
                    Console.WriteLine("\t\tPress b to Update Data.");
                    Console.WriteLine("\t\tPress c to Delete Data.");
                    Console.WriteLine("\t\tPress d to Show All Employee Table Data.");
                    Console.WriteLine("\t\tPress e to Show a Perticular Employee Data.");

                    string choice2 = Console.ReadLine();
                    switch (choice2)
                    {
                        case "a":
                            string result = employeeData.InsertEmp();
                            Console.WriteLine(result);
                            break;
                        case "b":
                            result = employeeData.UpdateEmp();
                            Console.WriteLine(result);
                            break;
                        case "c":
                            Console.WriteLine("\nEnter The Customer ID to Delete :");
                            int EmpID = Convert.ToInt32(Console.ReadLine());
                            result = employeeData.DeleteEmp(EmpID);
                            Console.WriteLine(result);
                            break;
                        case "d":
                            Console.WriteLine();
                            dt = employeeData.SelectEmp();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("NO DATA FOUND");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;
                        case "e":
                            Console.WriteLine("Enter The Customer ID To See Its Details : ");
                            int SearchID = Convert.ToInt32(Console.ReadLine());
                            dt = employeeData.SelectEmpID();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                // int ID = (int)dt.Rows[i][0];
                                if ((int)dt.Rows[i][0] == SearchID)
                                {
                                    {
                                        for (int j = 0; j < dt.Columns.Count; j++)
                                        {

                                            Console.Write(dt.Rows[i][j] + "\t\t");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;

                    }
                    break;
                case 3:
                    AccountData accountData = new AccountData();
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress a to Insert Data.");
                    Console.WriteLine("\t\tPress b to Update Data.");
                    Console.WriteLine("\t\tPress c to Delete Data.");
                    Console.WriteLine("\t\tPress d to Show All Account Table Data.");
                    Console.WriteLine("\t\tPress e to Show a Perticular Account Data.");

                    string choice3 = Console.ReadLine();
                    switch (choice3)
                    {
                        case "a":
                            string result = accountData.InsertAccount();
                            Console.WriteLine(result);
                            break;
                        case "b":
                            result = accountData.UpdateAcc();
                            Console.WriteLine(result);
                            break;
                        case "c":
                            Console.WriteLine("\nEnter The Account Number to Delete Its Details :");
                            int EmpID = Convert.ToInt32(Console.ReadLine());
                            result = accountData.DeleteAcc(EmpID);
                            Console.WriteLine(result);
                            break;
                        case "d":
                            Console.WriteLine();
                            dt = accountData.SelectAcc();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("NO DATA FOUND");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;
                        case "e":
                            Console.WriteLine("Enter The Account Number To See Its Details : ");
                            int SearchID = Convert.ToInt32(Console.ReadLine());
                            dt = accountData.SelectAccNum();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                // int ID = (int)dt.Rows[i][0];
                                if ((int)dt.Rows[i][0] == SearchID)
                                {
                                    {
                                        for (int j = 0; j < dt.Columns.Count; j++)
                                        {

                                            Console.Write(dt.Rows[i][j] + "\t\t");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;

                    }
                    break;
                case 4:
                    break;
            }

        }
    }
}
