using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisTestavimas.Page
{
    public class InputPage

    {
        private static IWebDriver _driver;

        private IWebElement _inputField => _driver.FindElement(By.Id("user-message"));

        private IWebElement _showMessageButton => _driver.FindElement(By.CssSelector("#get-input > button"));

        private IWebElement _actualResultText => _driver.FindElement(By.Id("display"));

        private IWebElement _firstInput => _driver.FindElement(By.Id("sum1"));

        private IWebElement _secondInput => _driver.FindElement(By.Id("sum2"));

        private IWebElement _getTotalButton => _driver.FindElement(By.CssSelector("#gettotal > button"));

        private IWebElement _actualSumResult => _driver.FindElement(By.Id("displayvalue"));

        public InputPage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
        public void InsertTextToInputField(string text)
        {
            _inputField.Clear();
            _inputField.SendKeys(text);
        }

        public void ClickShowMessageButton()
        {
            _showMessageButton.Click();
        }

        public void VerifyResult(string result)
        {
            Assert.AreEqual(result, _actualResultText.Text, "Text is different");
        }
        public void InsertBothValuesInputField(string firstValue, string secondValue)
        {
            InsertTextToFirstInputField(firstValue);
            InsertTextToSecondInputField(secondValue);
        }
        public void InsertTextToFirstInputField(string text)
        {
            _firstInput.Clear();
            _firstInput.SendKeys(text);
        }

        public void InsertTextToSecondInputField(string text)
        {
            _secondInput.Clear();
            _secondInput.SendKeys(text);
        }

        public void ClickGetTotalButton()
        {
            _showMessageButton.Click();
        }

        public void VerifySumResult(string result)
        {
            Assert.AreEqual(result, _actualSumResult.Text, "Result is not correct!");
        }

        [Test]
        public static void TestInputField()
        {
            InputPage page = new InputPage(_driver);
            string text = "Masina";
            page.InsertTextToFirstInputField(text);
            page.ClickGetTotalButton();
            page.VerifyResult(text);
        }

        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a + b = NaN")]

        public static void TestSum(string firstValue, string secondValue, string expectedResult)
        {
            InputPage page = new InputPage(_driver);

            //page.InsertBothValuesInputField(firstValue, secondValue);
            page.InsertTextToFirstInputField(firstValue);
            page.InsertTextToSecondInputField(secondValue);
            page.VerifySumResult(expectedResult);

        }


    }
}


