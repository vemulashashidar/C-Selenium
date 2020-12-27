using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
namespace SeleniumCSharpTotal
{
    [TestFixture]
    class TestNg
    {
        ExtentReports extent = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReport = new ExtentHtmlReporter(@"C:\\Users\\Shashidar\\source\\repos\\SeleniumCSharp\\SeleniumCSharpTotal\\ExtentReports\Report.html");
            extent.AttachReporter(htmlReport);
        }


        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
        ExtentTest test1 = null;
        IWebDriver driver = null;
        [Test]
        public void Test1()
        {
            
            try
            {
                 test1 = extent.CreateTest("Test1").Info("Created");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test1.Log(Status.Info, "Chrome Launched");
                driver.Url = "https://www.facebook.com/";
                test1.Log(Status.Pass, "Facebook launched");
                driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
                test1.Log(Status.Pass, "dateofbirth clicked");
                Thread.Sleep(3000);
                IWebElement day = driver.FindElement(By.XPath(".//*[@id='day']"));
                SelectElement element = new SelectElement(day);
                element.SelectByText("18");
                test1.Log(Status.Pass, "Correct Entered Entered Value");
                Thread.Sleep(2000);
                test1.Log(Status.Info, "TestCompleted");

            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }


            }

        }
            [Test]
            public void Test2()
        { 
                try
                {
                    test1 = extent.CreateTest("Test2").Info("Created");
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    test1.Log(Status.Info, "Chrome Launched");
                    driver.Url = "https://www.facebook.com/";
                    test1.Log(Status.Info, "Facebook launched");
                    driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
                    test1.Log(Status.Info, "dateofbirth clicked");
                    Thread.Sleep(3000);
                    IWebElement day = driver.FindElement(By.XPath(".//*[@id='day']"));
                    SelectElement element = new SelectElement(day);
                    element.SelectByText("abc");
                    test1.Log(Status.Info, "Correct Entered Entered Value");
                    Thread.Sleep(2000);
                    test1.Log(Status.Pass, "TestCompleted");

                }
                catch(Exception e)
            {
                test1.Log(Status.Fail, e.ToString());
                throw;
            }
                finally
                {
                    if (driver != null)
                    {
                        driver.Quit();
                    }


                }

            }

    }
}
