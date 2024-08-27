using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_TestAssign2.Page
{
    internal class LoginPage
    {
        public LoginPage(IWebDriver WebDriver)
        {
            Driver = WebDriver;
        }
        private IWebDriver Driver {  get;}
        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));

        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));

        public void Login(string username, string password)
        {
            txtUserName.SendKeys("admin");
            txtPassword.SendKeys("password");
            btnLogin.Submit();

        }   }
}
