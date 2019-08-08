using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;


namespace UnitTestProject2
{
    class HaveYouSay 
    {
        private IWebDriver _driver;
        LoremIpsum loremIpsum = new LoremIpsum();

        public HaveYouSay(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public HaveYouSay()
        {
        }

        [FindsBy(How = How.XPath, Using ="//a[@ href='/news/have_your_say']")]
        private IWebElement HaveSay { get; set; }

        [FindsBy(How = How.XPath, Using = "(//h2[@id='featured-contents']/following-sibling::div//a)[1]")]
        private IWebElement Question { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea")]
       private IWebElement Textarea { get; set; }
              
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name']")]
        private IWebElement Name { get; set; }
              
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        private IWebElement Email { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Age']")]
        private IWebElement Age { get; set; }
      
        [FindsBy(How = How.XPath, Using = "//input[@ placeholder='Postcode']")]
        private IWebElement Postcode { get; set; }
             
        [FindsBy(How = How.XPath, Using = "//button[@class='button]")]
        private IWebElement SubmitButton { get; set; }
        

        public void SetSay()
        {
            HaveSay.Click();
            Question.Click();
        }
        
        public string GenerateFromIpsum()
        {
            string res1 = loremIpsum.GenerateTextL();
            return res1;
        }

        public void Dictionary() {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                ["text"] = GenerateFromIpsum(),
                ["name"] = "Natalia",
                ["email"] = "email@gmail.com",
                ["age"] = "21",
                ["postcode"] = "12345",
            };
    }

        private void SetFieldsTextArea(Dictionary<string,string> dictionary)
        {

            Textarea.Click();
            Textarea.SendKeys(dictionary["text"]);
            Name.Click();
            Name.SendKeys(dictionary["name"]);
            Email.Click();
            Email.SendKeys(dictionary["email"]);
            Age.Click();
            Age.SendKeys(dictionary["age"]);
            Postcode.Click();
            Postcode.SendKeys(dictionary["postcode"]);


        }

        public void Submit()
        {
            SubmitButton.Click();
        }


        public void GetScreenshot()
        {
            Screenshot screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
            screenshot.SaveAsFile("Test.png", ScreenshotImageFormat.Png);

        }
    }
}