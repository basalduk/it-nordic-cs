using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Storage.SqlServer.ADO.TEST
{
    [TestClass]
    class SqlReminderStorageTast
    {
        private const string _connectionString =
            @"Data Source = localhost\SQLEXPRESS; Initial Catalog = ReminderTest; Integrated Security = true;";

        public void TestInitialize()
        {
            new SqlReminderStorageUnit(_connectionString).InitalizationData();
        }

        [TestMethod]
        public void Method_Add_return()
            {
            var storage = new SqlReminderStorage(_connectionString);
            Guid actual = storage.Add(new Core.ReminderItemRestricted())
                {

            }
        
            Assert.AreEqual(Guid.Empty, actual);

        }
    }
}
