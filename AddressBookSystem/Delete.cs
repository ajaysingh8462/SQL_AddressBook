using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Delete
    {
        public static string connection = @"Data Source=DESKTOP-P65PD0V;Initial catalog=AddressBook;Integrated Security=true";
        SqlConnection sqlConnection = new SqlConnection(connection);
        public void DeleteContacts(string FirstName)
        {
            int result = 0;
            try
            {
                using (sqlConnection)
                {

                    SqlCommand sqlCommand = new SqlCommand("DeleteRcords", this.sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
                    sqlConnection.Open();

                    result = sqlCommand.ExecuteNonQuery();

                    if (result != 0)
                    {
                        Console.WriteLine("Deleted succsesfully");
                    }
                    else
                    {
                        Console.WriteLine("invalid Name");

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
