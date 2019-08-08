using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject2
{
    class HomePage
    {
        private IWebDriver _driver;
        private readonly WebDriverWait _wait;
       
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, 5));
            PageLoaded();


        }

        public HomePage()
        {
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='https://www.bbc.com/news']")]
        private IWebElement News { get; set; }

        public void GoHomePage()
        {
            _driver.Navigate().GoToUrl("https://www.bbc.com/");
        }

        private void PageLoaded()
        {
            _wait.Until(_driver => News.Displayed);
        }
    }
}
