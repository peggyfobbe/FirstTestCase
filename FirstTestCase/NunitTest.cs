using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace FirstTestCase
{
    class NunitTest
    {
        IWebDriver driver;

     [SetUp]
#pragma warning restore CS0246 // The type or namespace name 'SetUp' could not be found (are you missing a using directive or an assembly reference?)
        public void Initialize()
        {
            driver = new ChromeDriver();
        }

  [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.demoqa.com";
            
        }

  [TearDown]
     public void EndTest()
        {
            driver.Close();
        }
    }
}
