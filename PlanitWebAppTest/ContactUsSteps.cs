using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace PlanitWebAppTest
{
    [Binding]
    public class ContactUsSteps
    {
        private IWebDriver _driver;
        [Given(@"I am on Planit'(.*)'Contact Us' page")]
        public void GivenIAmOnPlanitContactUsPage(string p0)
        {
            _driver = new ChromeDriver(@"C:\Users\axia\Documents\"); //Alternatively, add chromedriver to project or add as a System path variable
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://planittesting.com/Contact");
            }

        [Given(@"no job title has been specified")]
        public void GivenNoJobTitleHasBeenSpecified()
        {
            string jobTitleFieldId = "p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_JobTitle_txtText";
            IWebElement jobTitleField = _driver.FindElement(By.Id(jobTitleFieldId));
            jobTitleField.SendKeys("");
        }

        [Then(@"an error prompt for blank job title appears")]
        public void ThenAnErrorPromptForBlankJobTitleAppears()
        {
            string noJobEnteredErrorMessage = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_JobTitle_lbe")).Text;
            Assert.AreEqual("Please enter your job title", noJobEnteredErrorMessage, "Strings do not match");
        }

        [Given(@"I have entered a first name of (.*)")]
        public void GivenIHaveEnteredAFirstNameOf(string firstName)
        {
            string firstNameFieldId = "p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText";
            IWebElement firstNameField = _driver.FindElement(By.Id(firstNameFieldId));
            firstNameField.SendKeys(firstName);
        }

        [Given(@"I have entered a last name of (.*)")]
        public void GivenIHaveEnteredALastNameOf(string lastName)
        {
            string lastNameFieldId = "p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_LastName_txtText";
            IWebElement lastNameField = _driver.FindElement(By.Id(lastNameFieldId));
            lastNameField.SendKeys(lastName);
        }

        [When(@"I submit my enquiry")]
        public void WhenISubmitMyEnquiry()
        {
            string submitButtonId = "p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_btnOK";
            IWebElement submitButton = _driver.FindElement(By.Id(submitButtonId));
            submitButton.Click();
        }

        [Given(@"there has been no specified email address")]
        public void GivenThereHasBeenNoSpecifiedEmailAddress()
        {
            string lastNameFieldId = "p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_Email_txtText";
            IWebElement lastNameField = _driver.FindElement(By.Id(lastNameFieldId));
            lastNameField.SendKeys("");
        }

        [Then(@"an error prompt for blank email address appears")]
        public void ThenAnErrorPromptForBlankEmailAddressAppears()
        {
            string noJobEnteredErrorMessage = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_Email_lbe")).Text;
            Assert.AreEqual("Please enter an email address", noJobEnteredErrorMessage, "Strings do not match");
        }


        


        [AfterScenario]
        public void disposeDriver()
        {
            _driver.Dispose();
        }
    }
}
