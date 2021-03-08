using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDbTests.Pages
{
    public class Home
    {
        private IWebDriver Driver { get; }

        public Home(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebElement linkRegister => Driver.FindElement(By.Id("registerLink"));
        public void ClickRegister() => linkRegister.Click();

        public IWebElement titleRegister => Driver.FindElement(By.LinkText("Register"));


        public bool IsTitleRegisterExist() => titleRegister.Displayed;

    }
}
