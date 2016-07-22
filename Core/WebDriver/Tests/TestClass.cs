using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;
using NUnit.Framework;

namespace WebDriver.Tests
{
    [TestFixture]
    public class TestClass
    {

        private Steps.Steps steps = new Steps.Steps();
        private const string USEREMAIL = "anastasiyaliazhniuk@gmail.com";
         private const string USERPASSWORD = "meniti82";
   
     
        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void CleanUp()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void UserLoginsGmail()
        {
            steps.LoginGmail(USEREMAIL, USERPASSWORD);

        }

    }
}
