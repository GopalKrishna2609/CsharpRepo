using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//connect sql server
using System.Data;
namespace CustomerDBConsole
{
    internal class CustomerData
    {

        public static string SqlConnectionString = "Data Source=DESKTOP-CEIJQT1;Initial Catalog=BankDB;Integrated Security=True";

        public string InsertCust()
        {
            Console.Write("Enter Cutomer ID :");
            int CustID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Cutomer Name :");
            string CustName = Console.ReadLine();
            Console.Write("Enter Cutomer Email Aadress :");
            string CustEmail = Console.ReadLine();
            Console.Write("Enter Cutomer Mobile :");
            int CustMobile = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Cutomer Address :");
            string CustAddress = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Customer values(" + CustID + ",'" + CustName + "','" + CustEmail + "'," + CustMobile + ",'" + CustAddress + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Inserted";

            return "Inserted";

        }

        public string UpdateCust()
        {
            Console.Write("Enter Customer Id to update: ");
            int CustID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer name  to update: ");
            string CustName = Console.ReadLine();

            Console.Write("Enter Customer email  to update: ");
            string CustEmail = Console.ReadLine();

            Console.Write("Enter Customer Mobile  to update: ");
            int CustMobile = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer address  to update: ");
            string CustAddress = Console.ReadLine();

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString);//connection establishment
            SqlCommand cmd = new SqlCommand("update Customer set CustName='" + CustName + "' , Email='" + CustEmail + "' , Mobile=" + CustMobile + " , Address='" + CustAddress + "' where ID=" + CustID + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }

        public string DeleteCust(int CustID)
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString);//connection establishment
            SqlCommand cmd = new SqlCommand("DELETE from Customer where ID = " + CustID, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }

        public DataTable SelectCust()
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from Customer", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }

        public DataTable SelectCustID()
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * from Customer", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
    }


}


