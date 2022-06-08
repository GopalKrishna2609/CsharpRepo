using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CustomerDBConsole
{
    internal class AccountData

    {
        public static string SqlConnectionString2 = "Data Source=DESKTOP-CEIJQT1;Initial Catalog=BankDB;Integrated Security=True";

        public string InsertAccount()
        {
            Console.Write("Enter Account No :");
            int AccNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name Of Account Holder:");
            string AccHolder = Console.ReadLine();
            Console.Write("Enter Account Balance :");
            int AccBal = Convert.ToInt32(Console.ReadLine());


            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString2);
            SqlCommand cmd = new SqlCommand("insert into Account values(" + AccNum + ",'" + AccHolder + "'," + AccBal + ",)", sqlConnection);
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
