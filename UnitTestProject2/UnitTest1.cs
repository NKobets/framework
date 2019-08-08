using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();
        LoremIpsum lIpsum = new LoremIpsum();
        HaveYouSay haveYouSay = new HaveYouSay();
        HomePage homePage = new HomePage();
        NewsPage newsPage = new NewsPage();

        [TestMethod]
        public void TestMethod3()
        { 
          
           driver.Navigate().GoToUrl("https://www.lipsum.com");
         

          


            

        }

    }
}
