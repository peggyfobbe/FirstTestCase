using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstTestCase.Selenium_Basics
{
    class BrowserCommands
    {
        [Test]
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
