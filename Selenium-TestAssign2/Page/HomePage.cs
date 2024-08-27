using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_TestAssign2.Page
{
    internal class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver { get;  }
        public IWebElement lnklogin => Driver.FindElement(By.LinkText("login"));
        IWebElement linkEmployeeDetails => Driver.FindElement(By.LinkText("Employee Details"));
        public void Clicklogin()=> lnklogin.Click();
        public bool IsEmployeeDetailsExists() => linkEmployeeDetails.Displayed;
    }
}
