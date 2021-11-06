using System;
using System.Data;

namespace AddressBook_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Using Linq!");
            AddressBookTable addressBookTable = new AddressBookTable();
            DataTable dataTable = addressBookTable.AddAddressBookDataTable();
            //addressBookTable.DisplayContacts(dataTable);
            //addressBookTable.EditContact(dataTable);
            //addressBookTable.DeleteContact(dataTable);
            //addressBookTable.RetrieveContactBelongingToCityOrState(dataTable);
            //addressBookTable.GetSizeByCityOrState(dataTable);
            addressBookTable.SortContacts(dataTable);
        }
    }
}
