using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            return "Inserted";

        }

        public string UpdateCust()
        {
            return "";
        }

        public string DeleteCust()
        {
            return "";
        }

        public string SelectCust()
        {
            return "";
        }

        public string SelectCustID()
        {
            return "";
        }
    }


}
