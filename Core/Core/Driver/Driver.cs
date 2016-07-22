using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace Core.Driver
{
    public class Driver
    {
        private static IWebDriver _driver = CreatDriver();

        private Driver() { }

        public static IWebDriver GetDriver()
        {
            //_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            //_driver.Manage().Window.Maximize();
            return _driver;
        }


        public static IWebDriver CreatDriver()
        {
            string _browser = Data.browser;

            switch (_browser)
            {
                case "Firefox":
                    return new FirefoxDriver();
                case "Chrome":
                    return new ChromeDriver();
                case "IE":
                    return new InternetExplorerDriver();
                default:
                    return new FirefoxDriver();
            }
        }

        public static void CloseBrowser()
        {
            _driver.Close();
            _driver = null;
        }
    }
}
