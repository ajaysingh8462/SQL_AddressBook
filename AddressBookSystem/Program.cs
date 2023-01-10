using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class program
    {
        public static void Main(string[] args)
        {
            AddressBookDataBase.CreateDatabass();
        }
    }
}