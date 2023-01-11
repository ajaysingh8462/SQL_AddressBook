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
            //AddressBookDataBase.CreateDatabass();
            Console.WriteLine("Enter Option\n1.Create Table (Address Book)\n2.Insert contact  ");
            int op = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (op)
                {
                    case 1:
                        Table.CreateTable();
                        break;
                        case 2:
                        InsertData.InsertContact();
                        break;
                }
                break;            
            }
        }
    }
}