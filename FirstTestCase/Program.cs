using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FirstTestCase
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.demoqa.com";

        }
    }
}
