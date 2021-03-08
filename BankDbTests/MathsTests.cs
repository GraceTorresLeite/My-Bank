using BankDb;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Linq;

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

        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
         "|DataDirectory|\\clients.csv", "clients#csv",
          DataAccessMethod.Sequential), DeploymentItem("Data\\clients.csv")]
        [TestMethod]
        public void MigrationCSV()
        {

           
           Console.WriteLine(TestContext.DataRow["Id"].ToString());
            //int id = (int)TestContext.DataRow["Id"];
            //string name = (TestContext.DataRow["Nome"].ToString());
            //string email = (TestContext.DataRow["Email"].ToString());
            //DateTime birth = (DateTime)TestContext.DataRow["Nascimento"];
            //string gender = (TestContext.DataRow["Genero"].ToString());
            //string civilState = (TestContext.DataRow["Estado Civil"].ToString());
            //client.ValidaClient(id);
            //client = new Client(id,name,email,birth,gender,civilState);


            //var numberClientsExpected = 2;
            //var numberClientsActual = client._clients.Count();

            //Console.WriteLine(client._clients);
            //Assert.AreEqual(numberClientsExpected, numberClientsActual);

        }
    }
}
