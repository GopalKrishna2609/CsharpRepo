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
            int result = cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Inserted";

            return "Inserted";

        }

        public string UpdateAcc()
        {
            Console.Write("Enter Account No :");
            int AccNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name Of Account Holder:");
            string AccHolder = Console.ReadLine();
            Console.Write("Enter Account Balance :");
            int AccBal = Convert.ToInt32(Console.ReadLine());
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString2);
            SqlCommand cmd = new SqlCommand("update Account set AccHolder = '" + AccHolder + "' , AccBal = '" + AccBal + "' where AccNum=" + AccNum + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Inserted";

            return "Inserted";
        }

        public string DeleteAcc(int AccNum)
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString2);//connection establishment
            SqlCommand cmd = new SqlCommand("DELETE from Account where AccNum = " + AccNum, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }

        public DataTable SelectAcc()
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString2);
            SqlCommand cmd = new SqlCommand("SELECT * from Account", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }

        public DataTable SelectAccNum()
        {
            SqlConnection sqlConnection = new SqlConnection(SqlConnectionString2);
            SqlCommand cmd = new SqlCommand("SELECT * from Account", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
    }
}
