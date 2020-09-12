using DateTimeBDD.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
namespace DateTimeBDD.steps
{
    [Binding]
    public sealed class subtract2dates
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        page1 page1 = null;
        [Given(@"I Launch the Application")]
        public void GivenILaunchTheApplication()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Navigate().GoToUrl("https://localhost:44358");
            page1 = new page1(webdriver);
        }

       


        [Given(@"I select Subtract (.*) dates from the menu")]
        public void GivenISelectSubtractDatesFromTheMenu(int p0)
        {
            IWebDriver driver = new ChromeDriver();
            page1 = new page1(driver);
            SelectElement op = new SelectElement(page1.option);
            op.SelectByValue("1");
        }
        [Given(@"I click the submit button")]
        public void GivenIClickTheSubmitButton()
        {
            page1.ClickSubmit();
        }

        [When(@"I enter the input dates")]
        public void WhenIEnterTheInputDates()
        {
            IWebDriver driver = new ChromeDriver();
            page1 = new page1(driver);
            SelectElement date1 = new SelectElement(page1.date1);
            date1.SelectByValue("23");
            SelectElement month1 = new SelectElement(page1.month1);
            month1.SelectByValue("5");
            SelectElement hr1 = new SelectElement(page1.hr1);
            hr1.SelectByValue("14");

        }

        [When(@"I click the submit button")]
        public void WhenIClickTheSubmitButton()
        {
            page1.ClickSubmit();
        }

        [Then(@"I should see the result")]
        public void ThenIShouldSeeTheResult()
        {
            Assert.That(page1.isResultExist());
        }

    }
}
