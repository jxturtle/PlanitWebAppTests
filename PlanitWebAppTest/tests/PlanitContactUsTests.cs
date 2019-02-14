using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace PlanitWebAppTest
{
    class PlanitContactUsTests
    {
        //[Test]
        public void testNavigateToContactPage()
        {
            using (IWebDriver driver = new ChromeDriver(@"C:\Users\axia\Documents\")) //Alternatively, add chromedriver to project or add as a System path variable
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://planittesting.com");

                string contactUsButtonId = "p_lt_ctl03_pageplaceholder_p_lt_ctl02_PlanIt_ContactUsATag";
                IWebElement contactUs = driver.FindElement(By.Id(contactUsButtonId));
                contactUs.Click();

                Assert.AreEqual("Planit - Contact Planit: The Leaders in Quality Engineering", driver.Title);
            }
        }

        //[Test]
        public void testErrorMessageNoJobTitle()
        {
            using (IWebDriver driver = new ChromeDriver(@"C:\Users\axia\Documents\")) //Alternatively, add chromedriver to project or add as a System path variable
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://planittesting.com/Contact");

                string firstNameFieldId = "p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText";
                string lastNameFieldId = "p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_LastName_txtText";
                string submitButtonId = "p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_btnOK";

                IWebElement firstNameField = driver.FindElement(By.Id(firstNameFieldId));
                firstNameField.SendKeys("Yes");

                IWebElement lastNameField = driver.FindElement(By.Id(lastNameFieldId));
                lastNameField.SendKeys("Sir");

                IWebElement submitButton = driver.FindElement(By.Id(submitButtonId));
                submitButton.Click();

                string noJobEnteredErrorMessage = driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_JobTitle_lbe")).Text;
                Assert.AreEqual("Please enter your job title", noJobEnteredErrorMessage, "Strings do not match");
            }
        }
    }
}
