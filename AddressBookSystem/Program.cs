using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class program
    {
        public static void Main(string[] args)
        {
            //AddressBookDataBase.CreateDatabass();
            Console.WriteLine("Enter Option\n1.Create Table (Address Book)\n2.Insert contact\n3.Edit Contact\n4. Display contacts\n5 Delete Record\n6.Find Persons by City or State ");
            int op = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (op)
                {
                    case 1:
                        Table.CreateTable();
                        break;
                        case 2:
                        InsertData data = new InsertData();
                        Console.WriteLine("Enter FirstName");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine("Enter LastName");
                        string LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        string Address = Console.ReadLine();
                        Console.WriteLine("Enter City");
                        string City = Console.ReadLine();
                        Console.WriteLine("Enter State");
                        string State = Console.ReadLine();
                        Console.WriteLine("Enter Zip");
                        int Zip = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter PhoneNumber");
                        long PhoneNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter Email");
                        string Email = Console.ReadLine();
                        data.InsertIntoTable(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
                        break;
                    case 3:
                        UpdateContact update =new UpdateContact();
                        update.EditContact();
                        break;
                        case 4:
                        Display display= new Display();
                        display.DisplayEmployeeDetails();
                        break;
                        case 5:
                        Delete delete =new Delete();
                        Console.WriteLine("Enter FirstName to remove from table");
                        string Firstname = Console.ReadLine();
                        delete.DeleteContacts(Firstname);
                        break;
                        case 6:
                        Console.WriteLine("Find Persons by City or State");
                        Console.WriteLine("1.Find Person by City\n2.Find Person by State");
                        int check = Convert.ToInt32(Console.ReadLine());
                        Find_Person fn = new Find_Person();
                        switch (check)
                        {
                            case 1:
                                Console.WriteLine("Enter City To find perosn");
                                string city = Console.ReadLine();
                                fn.Find_Person_City(city);
                                break;
                            case 2:
                                Console.WriteLine("Enter State To find perosn");
                                string state = Console.ReadLine();
                                fn.Find_Person_State(state);
                                break;
                        }
                        break;
                }
                break;            
            }
        }
    }
}