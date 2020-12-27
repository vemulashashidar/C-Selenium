// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.Collections.Generic;
using SeleniumCSharpTotal.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;

namespace SeleniumCSharpTotal
{
    [TestFixture]
    public class OrderSkip 
    {
        [Test,Order(0), Category("OrderSkip")]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://www.facebook.com/");
            driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
            Thread.Sleep(3000);
            IWebElement day = driver.FindElement(By.XPath(".//*[@id='day']"));
            SelectElement element = new SelectElement(day);
            element.SelectByText("18");
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test,Order(1), Category("OrderSkip")]
        public void TestMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://www.facebook.com/");
            driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
            Thread.Sleep(3000);
            IWebElement day = driver.FindElement(By.XPath(".//*[@id='day']"));
            SelectElement element = new SelectElement(day);
            element.SelectByText("20");
            Thread.Sleep(1000);
            driver.Close();
        }

    }
}
