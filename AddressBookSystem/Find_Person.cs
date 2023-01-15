using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Find_Person
    {
        public static string connection = @"Data Source=DESKTOP-P65PD0V;Initial catalog=AddressBook;Integrated Security=true";
        SqlConnection sqlConnection = new SqlConnection(connection);
        public void Find_Person_City(string City)
        {
            Contact con = new Contact();
            try
            {
                using (sqlConnection)
                {
                    SqlCommand sqlCommand = new SqlCommand("SearchByCity", this.sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@City", City);
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            con.FirstName = dataReader.GetString(1);
                            con.LastName = dataReader.GetString(2);
                            con.Address = dataReader.GetString(3);
                            con.City = dataReader.GetString(4);
                            con.State = dataReader.GetString(5);
                            con.Zip = dataReader.GetInt32(6);
                            con.PhoneNumber = dataReader.GetInt64(7);
                            con.Email = dataReader.GetString(8);
                            Console.WriteLine(con.FirstName + " " + con.LastName + " " + con.Address + " " + con.City + " " + con.State + " " + con.Zip + " " + con.PhoneNumber + " " + con.Email);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void Find_Person_State(string State)
        {
            Contact con = new Contact();
            try
            {
                using (sqlConnection)
                {
                    SqlCommand sqlCommand = new SqlCommand("SearchByState", this.sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@State", State);
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            con.FirstName = dataReader.GetString(1);
                            con.LastName = dataReader.GetString(2);
                            con.Address = dataReader.GetString(3);
                            con.City = dataReader.GetString(4);
                            con.State = dataReader.GetString(5);
                            con.Zip = dataReader.GetInt32(6);
                            con.PhoneNumber = dataReader.GetInt64(7);
                            con.Email = dataReader.GetString(8);
                            Console.WriteLine(con.FirstName + " " + con.LastName + " " + con.Address + " " + con.City + " " + con.State + " " + con.Zip + " " + con.PhoneNumber + " " + con.Email);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
