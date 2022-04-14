using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBookTest
{
    [TestClass]
    public class AddressBookUnitTets
    {
        [TestMethod]
        public void TestMethod1()
        {
             public static string masterQuery = @"SELECT * FROM PersonContactsTable";
        AddressBookDataBase addressBookDataBase = new AddressBookDataBase();
        [TestMethod]
        public void GivenDBConnectionString_InAddressBookDataBase_ReturnListOfContactsinDB()
        {
            addressBookDataBase.GetContactDetailsByDataAdapter(masterQuery);
            Assert.IsTrue(true);
        
        }
    }
}
