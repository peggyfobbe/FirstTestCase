using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstTestCase.Selenium_Basics
{
    class checkboxradionbtn
    {
        [Test]

        public void ChallengeOne()
        {
            //Launch new browser

            IWebDriver Driver = new ChromeDriver();

            //Open Tools SQA Practice Automation Form

            Driver.Url = "http://toolsqa.wpengine.com/automation-practice-form/";

            //Challegene One - Select the deselected Radio Button (female) for category Sex (Use Selected Method)

            IList<IWebElement> RadioBtn = Driver.FindElements(By.Name("sex"));

            //Create a boolean variable which will the value (True/False)

            bool bValue = false;

            //This statement will return True, in case of first Radio Button is selected

            bValue = RadioBtn.ElementAt(0).Selected;

            //This will check that if the bValue is True means if the frist radio button is selected

            if (bValue == true)

            {
                //This will select the Second Radio Button, if the first radio button is selected by default
                RadioBtn.ElementAt(0).Click();
            }
            else
            {
                // if the first radio button is not selected by default, the first will be selected

                RadioBtn.ElementAt(1).Click();

            }
        }
            [Test]

        public void ChallengeTwo()
        {
            //Challenge Two - Select the Third radio button for category 'Years of Exp' (Use ID attribute to select radio button



        }

        [Test]

        public void ChallengeThree()
        {
            //Challenge Three – Check the Check Box ‘Automation Tester’ for category ‘Profession'( Use Value attribute to match the selection)



        }

        [Test]

        public void ChallengeFour()
        { 
            //Challenge Four – Check the Check Box ‘Selenium IDE’ for category ‘Automation Tool’ (Use CssSelector)


}

        }

    }

