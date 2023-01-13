using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class UpdateContact
    {
        int result = 0;

        public static string connection = @"Data Source=DESKTOP-P65PD0V;Initial catalog=AddressBook;Integrated Security=true";
        SqlConnection sqlConnection = new SqlConnection(connection);
        public  void EditContact()
        {
            try
            {
                sqlConnection.Open();
                string query = "Update Address_Book set Email = 'Rahul23@gmail.com' where FirstName = 'rahul'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                result = sqlCommand.ExecuteNonQuery();

                if (result != 0)
                {
                    Console.WriteLine("Updated!");
                }
                else
                {
                    Console.WriteLine("Not Updated!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

    }
}
