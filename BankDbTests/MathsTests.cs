using BankDb;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankDbTests
{
    [TestClass]
    public class MathsTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        
        [DataSource(@"Provider=MSOLEDBSQL;Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MathsData;Integrated Security=SSPI;", "AddIntegersData")]
        [TestMethod]
        public void AddIntegers_FromDataSourceTest()
        {
            var target = new Maths();

            // access the data
            int x = (int)TestContext.DataRow["FirstNumber"];
            int y = (int)TestContext.DataRow["SecondNumber"];
            int expected = (int)TestContext.DataRow["Sum"];
            int actual = target.AddIntegers(x, y);
            Assert.AreEqual(expected, actual,
                "x:<{0}> y:<{1}>",
              new object[] { x, y });

           // Assert.AreEqual(expected, actual);

            //Console.WriteLine(expected + ":" + actual);

        }
    }
}
