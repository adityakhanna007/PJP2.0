using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace DateTimeBDD.Pages
{
    class page1
    {
        IWebDriver driver { get; }
          public page1(IWebDriver webdriver)
        {
            driver = webdriver;
        }



       
        public IWebElement option=>driver.FindElement(By.XPath("//select[@name='option']"));


            public IWebElement date1 => driver.FindElement(By.Id("date1"));
           
            public IWebElement month1 =>driver.FindElement(By.Id("month1"));
           
            public IWebElement hr1 => driver.FindElement(By.Id("hr1"));
           
             public IWebElement sec1 => driver.FindElement(By.Id("sec1"));
        public IWebElement result => driver.FindElement(By.Id("result"));
        public IWebElement submit => driver.FindElement(By.Id("submit"));
        public void ClickSubmit() => submit.Click();
        public bool isResultExist() => result.Displayed;


    }
}
