using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

using NUnit.Framework;
using DateTimeBDD.Pages;

namespace DateTimeBDD.steps
{
    [Binding]
    public sealed class ChangeLocale
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given(@"I Given I Launch the Application")]
        public void GivenIGivenILaunchTheApplication()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44323/Language");
            
        }

        [When(@"I select the german language")]
        public void WhenISelectTheGermanLanguage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.FindElement(By.Id("de")).Click();

        }

        [Then(@"I should see the output")]
        public void ThenIShouldSeeTheOutput()
        {
            IWebDriver driver = new ChromeDriver();
            page1 page1 = new page1(driver);
            Assert.That(page1.isResultExist());
        }

    }
}
