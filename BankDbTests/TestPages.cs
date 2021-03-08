using BankDbTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BankDbTests
{
    [TestClass]
    public class TestPages
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        IWebDriver webDriver = new ChromeDriver(@"C:\Program Files\Google\Chrome");

        [TestInitialize]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
         "|DataDirectory|\\clients.csv", "clients#csv",
          DataAccessMethod.Sequential), DeploymentItem("Data\\clients.csv")]
        [TestMethod]
        public void GoRegister()
        {
            var home = new Home(webDriver);
            home.ClickRegister();

            var register = new Register(webDriver);

            var name = "";

            if (TestContext.DataRow.IsNull("Nome") == false)
            {
                name = TestContext.DataRow["Nome"].ToString();
            }
           
            var password = TestContext.DataRow["Password"].ToString();
            
            var email = TestContext.DataRow["Email"].ToString();

            register.formRegister(name,password,email);

            var expected = home.IsTitleRegisterExist();

            Assert.IsTrue(expected);

            #region MyRegion
            //this.UIMap.EnterValueParams.UIItem0TextSendKeys = TestContext.DataRow["ValueOne"].ToString();

            //string password = TestContext.DataRow["Password"].ToString;
            //string passwordConfirm = TestContext.DataRow["Password"];
            //string email = TestContext.DataRow["Password"];
            //int actual = register.formRegister(userName, password, passwordConfirm, email);
            // Assert.AreEqual(expected, actual);
            #endregion




        }

        [TestCleanup]
        public void TearDown() => webDriver.Quit();
        
    }
}
