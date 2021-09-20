using AutomatinisTestavimas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisTestavimas.Test
{
    class CheckBoxDemoTest
    {
        private static IWebDriver _Driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _Driver = new ChromeDriver();
            _Driver.Manage().Window.Maximize();
            _Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _Driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";

            WebDriverWait wait = new WebDriverWait(_Driver, TimeSpan.FromSeconds(10));

            IWebElement popup = _Driver.FindElement(By.Id("at-cv-lightbox-close"));
            wait.Until(e => e.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            popup.Click();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _Driver.Close();
        }

        [Test]
        public static void CheckBoxDemo()
        {
            CheckBoxDemoInputPage page = new CheckBoxDemoInputPage(_Driver);
            string text = "Success - Check box is checked";
            string result = "Uncheck All";

            page.CheckSingleCheckboxDemoMessage(text);
            page.CheckIfbuttonSayUncheckAll(result);
        }
    }
}
