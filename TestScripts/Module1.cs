using NUnit.Framework;
using SeleniumCSharpTotal.BaseClass;
using SeleniumCSharpTotal.PageObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTotal.TestScripts
{
    [TestFixture]
   public class Module1 : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            var searchpage=new SearchPage(driver);
            searchpage.NavigateToResultPage();
        }
    }
}
