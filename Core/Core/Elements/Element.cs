using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Core.Elements
{
    public interface Element
    {

        bool IsDisplayed();

        bool IsPresent(By by);

        bool IsPresent();

        void SetLocator(By locator);

        void WaitForIsElementPresent(By locator);

        IWebElement getElement();
    }
}
