using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace FirstTestCase.Selenium_Basics
{
    class BrowserCommands
    {
        public void BrowserCommand()
        {
          
            IWebDriver driver = new ChromeDriver();
            
            //Open DemoQA.com Website
           
            driver.Navigate().GoToUrl("http://demoqa.com");

            driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().GoToUrl("http://demoqa.com");
            driver.Navigate().Refresh();
            driver.Close();

        }
        

        



    }
}
