using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTotal.PageObjectModel
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How=How.Id,Using = "search")]
        public IWebElement Searchbox { get; set; }
        [FindsBy(How =How.Id,Using = "search-icon-legacy")]
        public IWebElement Button { get; set; }
        public void NavigateToResultPage()
        {
            Searchbox.SendKeys("C# By BAKKAPPA N");
            Button.Click();
        }
    }
}
