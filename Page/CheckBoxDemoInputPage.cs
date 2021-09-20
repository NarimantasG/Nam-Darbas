using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisTestavimas.Page
{
    class CheckBoxDemoInputPage
    {
        private static IWebDriver _Driver;

        private IWebElement _clickOnThisCheckbox => _Driver.FindElement(By.Id("isAgeSelected"));

        private IWebElement _checkBoxIsChecked => _Driver.FindElement(By.Id("txtAge"));

        private IWebElement _checkBox1 => _Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(3) > label > input"));

        private IWebElement _checkBox2 => _Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(4) > label > input"));

        private IWebElement _checkBox3 => _Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(5) > label > input"));

        private IWebElement _checkBox4 => _Driver.FindElement(By.CssSelector("#easycont > div > div.col-md-6.text-left > div:nth-child(5) > div.panel-body > div:nth-child(6) > label > input"));

        private IWebElement _uncheckAll => _Driver.FindElement(By.Id("check1"));

        public CheckBoxDemoInputPage(IWebDriver webDriver)
        {
            _Driver = webDriver;
        }
        
        public void ClickOnSingleCheckboxDemoCheckbox()
        {
            _clickOnThisCheckbox.Click();
            
        }

        public void CheckSingleCheckboxDemoMessage(string Text)
        {
            Assert.AreEqual(Text,_checkBoxIsChecked.Text, "Text is different");
        }

        public void ClickCheckbox1()
        {
            _checkBox1.Click();
        }
        public void ClickCheckbox2()
        {
            _checkBox2.Click();
        }
        public void ClickCheckbox3()
        {
            _checkBox3.Click();
        }

        public void ClickCheckbox4()
        {
            _checkBox4.Click();
        }
        public void ClickUncheckAll1()
        {
            _uncheckAll.Click();
        }

        public void CheckIfbuttonSayUncheckAll(bool result)
        {
            Assert.AreEqual(_uncheckAll.Displayed, result, "Result is diffreant");
        }

        public void ClickUncheckAll()
        {
            _uncheckAll.Click();
        }

    }
}
