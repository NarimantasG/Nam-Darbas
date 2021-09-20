using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisTestavimas
{
    class Paskaita3
    {
        public static IWebDriver _driver;
        [Test]
        public static void MultipleCheckboxdemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            driver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


        
            IReadOnlyCollection<IWebElement> multipleCheckBoxes = _driver.FindElements(By.ClassName("cb1-element"));

            foreach (IWebElement checkBox in multipleCheckBoxes)
            {
                checkBox.Click();
            }
        }
        
        [Test]
        public static void TestButton()
        {
            IWebElement button = _driver.FindElement(By.CssSelector("#check1"));
            if (button.GetAttribute("value").Equals("Check All"))
            {
                button.Click();
            }
        }

        
    }
}
