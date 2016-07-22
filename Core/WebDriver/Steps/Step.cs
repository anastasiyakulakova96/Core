using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Core.Driver;

namespace WebDriver.Steps
{
    public class Steps
    {

        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Core.Driver.Driver.GetDriver();
        }

        public void CloseBrowser()
        {
            Core.Driver.Driver.CloseBrowser();
        }

        public void LoginGmail(string userEmail, string password)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.OpenPage();
            loginPage.Login(userEmail, password);
        }
    }
}
