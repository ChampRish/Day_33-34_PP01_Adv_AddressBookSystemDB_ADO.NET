using AddressBook_ADO.NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBookTest
{
    [TestClass]
    public class AddressBookUnitTets
    {
        [TestMethod]
        public void TestMethod1()


            public static string masterQuery = @"SELECT * FROM PersonContactsTable";
        AddressBookDataBase addressBookDataBase = new AddressBookDataBase();
        [TestMethod]
        public void GivenDBConnectionString_InAddressBookDataBase_ReturnListOfContactsinDB()
        {
            addressBookDataBase.GetContactDetailsByDataAdapter(masterQuery);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void GivenContactsUpdatedObject_InUpdateContactsMethod_Return()
        {
            Contacts contacts = new Contacts { firstName = "VINEY", lastName = "KHANEJA", city = "Ludhiana", state = "Punjab", zipCode = 110008 };
            var actual = addressBookDataBase.UpdateContactDetailsofAPerson(contacts);
            Assert.AreEqual("Punjab", actual.state);
        }

    
    
}
