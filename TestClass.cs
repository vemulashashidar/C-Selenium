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

namespace SeleniumCSharpTotal
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test,Category("Regression")]
        public void TestMethod()
        {
            /*driver.FindElement(By.XPath(".//*[@class='nav-line-2 nav-long-width']")).Click();
            Thread.Sleep(2000);*/
            driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
            Thread.Sleep(3000);
            IWebElement day = driver.FindElement(By.XPath(".//*[@id='day']"));
            SelectElement element = new SelectElement(day);
            element.SelectByText("18");
            Thread.Sleep(20000);
        }
       /* [Test,Category("Smoke")]
        public void TestMethod2()
        {

            driver.FindElement(By.XPath(".//*[@type='email']")).SendKeys("919032868586");
            Thread.Sleep(2000);
        }
        [Test,Category("Smoke")]
        public void TestMethod3()
        {
            driver.FindElement(By.XPath(".//*[@id='continue']")).Click();
            driver.FindElement(By.XPath(".//*[@type='password']")).SendKeys("susheel@123");
            driver.FindElement(By.XPath(".//*[@id='signInSubmit']")).Click();
            Thread.Sleep(2000);
        }*/
    }
}
