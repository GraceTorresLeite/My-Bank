using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDbTests.Pages
{
    public class Register
    {

        private IWebDriver Driver { get; }

        public Register(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement textUserName => Driver.FindElement(By.Id("UserName"));
        public IWebElement textPassword => Driver.FindElement(By.Id("Password"));
        public IWebElement textConfirmPassword => Driver.FindElement(By.Id("ConfirmPassword"));
        public IWebElement textEmail => Driver.FindElement(By.Id("Email"));
        public IWebElement btnRegister => Driver.FindElement(By.XPath("//input[@type='submit']"));


        public void formRegister(string userName, string password, string email)
        {
            textUserName.SendKeys(userName);
            textPassword.SendKeys(password);
            textConfirmPassword.SendKeys(password);
            textEmail.SendKeys(email);
            btnRegister.Submit();
        }

    }
}
