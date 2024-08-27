using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenium_TestAssign2.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_TestAssign2.Test
{
    public class LoginTest
    {
        IWebDriver driver;
        public LoginTest()
        {
            driver = new ChromeDriver(@"C:\Users\91789\Downloads\chromedriver-win64\chromedriver-win64");

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            //Console.WriteLine("exe first");
        }

        [Fact]
        public void TestCase()
        {
            HomePage homePage = new HomePage (driver);
            homePage.Clicklogin();
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("admin", "password");
            Assert.True(homePage.IsEmployeeDetailsExists());
            Console.WriteLine("exec later");
        }
    }
}
