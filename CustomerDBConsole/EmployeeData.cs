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
            int result = cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Inserted";

            return "Inserted";
        }

        public string UpdateEmp()
        {
            Console.Write("Enter Employee Id to update: ");
            int EmpID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee name  to update: ");
            string EmpName = Console.ReadLine();

            Console.Write("Enter Employee name  to update: ");
            string EmpAge = Console.ReadLine();

            Console.Write("Enter Employee email  to update: ");
            string EmpEmail = Console.ReadLine();

            Console.Write("Enter Employee Mobile  to update: ");
            int EmpMobile = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee address  to update: ");
            string EmpAddress = Console.ReadLine();

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString1);//connection establishment
            SqlCommand cmd = new SqlCommand("update Employee set EmpName = '" + EmpName + "' , EmpAge = '" + EmpAge+ "' , Email='" + EmpEmail + "' , Mobile=" + EmpMobile + " , Address='" + EmpAddress + "' where ID=" + EmpID + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }

        public string DeleteEmp(int EmpID)
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString1);//connection establishment
            SqlCommand cmd = new SqlCommand("DELETE from Employee where ID = " + EmpID, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }

        public DataTable SelectEmp()
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString1);
            SqlCommand cmd = new SqlCommand("SELECT * from Employee", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }

        public DataTable SelectEmpID()
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString1);
            SqlCommand cmd = new SqlCommand("SELECT * from Employee", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
    }
}
