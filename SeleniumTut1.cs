using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpTotal
{
    [TestFixture]
    class SeleniumTut1
    {
        IWebDriver driver = null;
        [Test]
        [Author("SHASHIDAR","vemulashashidar82@gmail.com")]
        [Description("Facebook Login")]
        [TestCaseSource("DataDriven")]
        public void Test1(string list)
        {
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = list;
                driver.FindElement(By.XPath(".//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
                Thread.Sleep(3000);
                IWebElement day = driver.FindElement(By.XPath(".//*[@id='day']"));
                SelectElement element = new SelectElement(day);
                element.SelectByText("abc");
                Thread.Sleep(2000);

            }
            catch (Exception e)
            {
                ITakesScreenshot ts=driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Shashidar\\source\\repos\\SeleniumCSharp\\SeleniumCSharpTotal\\Screenshots\\s1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
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
        
        static IList DataDriven()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            return list;
        }


    }
}
