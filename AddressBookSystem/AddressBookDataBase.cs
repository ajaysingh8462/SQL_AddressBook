using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookDataBase
    {
        public static void CreateDatabass()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P65PD0V;Initial catalog=master;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create database AddressBook", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Databass ctearted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
