using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class InsertData:Contact
    {
        public static string connection = @"Data Source=DESKTOP-P65PD0V;Initial catalog=AddressBook;Integrated Security=true";
        SqlConnection sqlConnection = new SqlConnection(connection);
        public void InsertIntoTable(string FirstName, string LastName, string Address, string City, string State, int Zip, long PhoneNumber, string Email)
        {

            int result = 0;
            try
            {
                using (sqlConnection)
                {
                    SqlCommand sqlCommand = new SqlCommand("spInsertintoTable", this.sqlConnection);

                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", LastName);
                    sqlCommand.Parameters.AddWithValue("@Address", Address);
                    sqlCommand.Parameters.AddWithValue("@City", City);
                    sqlCommand.Parameters.AddWithValue("@State", State);
                    sqlCommand.Parameters.AddWithValue("@zip",Zip);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    sqlCommand.Parameters.AddWithValue("@Email", Email);
                    sqlConnection.Open();
                    result = sqlCommand.ExecuteNonQuery();
                    if (result != 0)
                    {
                        Console.WriteLine("Contact Inserted");
                    }
                    else
                    {
                        Console.WriteLine("Not Updated");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
