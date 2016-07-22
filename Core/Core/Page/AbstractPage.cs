using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core.Page
{
    public abstract class AbstractPage
    {
        public abstract void OpenPage();

        public bool IsElementPresent(By locator)
        {
            return Core.Driver.Driver.CreatDriver().FindElements(locator).Count > 0;
        }

    }
}
