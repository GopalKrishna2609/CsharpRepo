using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDBConsole
{
    internal class EmployeeData
    {
        public static string SqlConnectionString1 = "Data Source=DESKTOP-CEIJQT1;Initial Catalog=BankDB;Integrated Security=True";

        public string InsertEmp()
        {
            Console.Write("Enter Employee ID :");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name :");
            string EmpName = Console.ReadLine();
            Console.Write("Enter Employee Age :");
            int EmpAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Email Aadress :");
            string Email = Console.ReadLine();
            Console.Write("Enter Employee Mobile :");
            int Mobile = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Address :");
            string Address = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString1);
            SqlCommand cmd = new SqlCommand("insert into Employee values(" + ID + ",'" + EmpName + "'," + EmpAge + ",'" + Email + "'," + Mobile + ",'" + Address + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            return "Inserted";

        }

        //public string UpdateCust()
        //{
        //    return "";
        //}

        //public string DeleteCust()
        //{
        //    return "";
        //}

        //public string SelectCust()
        //{
        //    return "";
        //}

        //public string SelectCustID()
        //{
        //    return "";
        //}
    }
}
