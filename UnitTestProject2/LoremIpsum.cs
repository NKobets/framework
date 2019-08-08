using System;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace UnitTestProject2
{
    class LoremIpsum
    {
        private  IWebDriver _driver;
        readonly int amountOfSymbols = 141;

        public LoremIpsum(IWebDriver driver)
        {
           _driver = driver;
          PageFactory.InitElements(_driver, this);  
         
        }

        public LoremIpsum()
        {
           
        }
        public void LoremIpsumLoad()
        {
            _driver.Navigate().GoToUrl("https://www.lipsum.com");
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='amount']")]
        private IWebElement AmountOFSymb { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@id='bytes']")]
        private IWebElement Radiobutton { get; set; }

       
        [FindsBy(How = How.XPath, Using = "//input[@id='generate']")]
        private IWebElement GenerateButton { get; set; }

       
        [FindsBy(How = How.XPath, Using = "//*[@id='lipsum']/p")]
        private IWebElement GenerateText { get; set; }


        public void TakeInf(int amoutOfSymb)
        {
            AmountOFSymb.Click();
            AmountOFSymb.Clear();
            AmountOFSymb.SendKeys(amoutOfSymb.ToString());
            Radiobutton.Click();
            GenerateButton.Click();
            
        }

        public string GenerateTextL()
        {
           string res = GenerateText.ToString();
            string result = res.Substring(0, res.Length - 1);
            return result;
        }

    }
}
