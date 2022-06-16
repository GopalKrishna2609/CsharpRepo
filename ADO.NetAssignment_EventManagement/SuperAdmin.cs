using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetAssignment_EventManagement
{
    internal class SuperAdmin
    {
        public static string sqlConnectionStr = @"Data Source=DESKTOP-CEIJQT1;Initial Catalog=EventManagement;Integrated Security=True";

        public void IMSuperAdmin()
        {
            Console.WriteLine("---------------WELCOME TO SUPER ADMIN MUDULE---------------");
            Console.WriteLine("Super admin is allowed to create a ADMIN only.");
        Add:
            Console.WriteLine();
            Console.WriteLine("Enter 1 to create a ADMIN.");
            Console.WriteLine("Enter 2 to logout.");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                SuperAdmin superAdmin = new SuperAdmin();
                superAdmin.CreateAdmin();
                goto Add;
            }
            else if (i == 2)
            {
                return;
            }
        }

        public string CreateAdmin()
        {
            Console.Write("Enter Admin name: ");
            string adminName = (Console.ReadLine());

            Console.Write("Enter Admin Role(SuperAdmin/Admin): ");
            string adminRole = Console.ReadLine();


            //insert into Admin Table

            #region disconnected-mode
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection stablishmentg
            SqlDataAdapter sda = new SqlDataAdapter("insert into Admin values('" + adminName + "','" + adminRole + "')", sqlConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return "Admin Created";
            #endregion
        }
    }
}
