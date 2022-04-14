using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContactsDetailinAddressBook();
            FileIOOperations.ReadingAllPersonContactsinFile();
            //addressBook.DisplayContactsInAddressBookDictionary();
            //addressBook.SeachingPersonByCityNameAndCountingAlso();
            //addressBook.SeachingPersonByStateNameAndCountingAlso();

        }
    }
}
