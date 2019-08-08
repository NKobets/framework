
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UnitTestProject2
{
    class NewsPage
    {
        private IWebDriver _driver;

        public NewsPage()
        {
        }

        public NewsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }
        [FindsBy(How = How.XPath, Using = "//a[@href='https://www.bbc.com/news']")]
        private IWebElement News { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='gel-long-primer gs-u-ph']")]
        private IWebElement More { get; set; }

        public void SetNews()
        {
            News.Click();
            More.Click();
        }
      
    }
}
