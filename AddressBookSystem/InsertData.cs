using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class InsertData
    {
        public static void InsertContact()
        {
            try
            {
                
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P65PD0V;Initial catalog=AddressBook;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Address_Book values('Ajay','Singh','Sector 45','gurgaon', 'haryana', 430002, 7898345625,'ajay@gmail.com')", connection);
                SqlCommand insrt = new SqlCommand("insert into Address_Book values('Teena','Saini','sector 47','Haridwar', 'Uttrakhand', 480025, 8978545252,'Teena@gmail.com')", connection);
                SqlCommand add = new SqlCommand("insert into Address_Book values('rahul','Singh','Sector 45','Bawal', 'haryana', 4300045, 7898345878,'Rahul23@gmail.com')", connection);
                cmd.ExecuteNonQuery();
                insrt.ExecuteNonQuery();
                add.ExecuteNonQuery();
                Console.WriteLine("Contact inserted");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
