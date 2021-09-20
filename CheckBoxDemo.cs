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
    public class CheckBoxDemo
    {
        [Test]
        public static void Checkboxdemo()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            driver.Manage().Window.Maximize();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //suranda issokancios reklamos elementa
            IWebElement popup = driver.FindElement(By.Id("at-cv-lightbox-close"));


            wait.Until(e => e.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            popup.Click();

            IWebElement checkbox = driver.FindElement(By.Id("isAgeSelected"));
            checkbox.Click();
            IWebElement actualresult = driver.FindElement(By.Id("txtAge"));

            string result = "";
            Assert.AreEqual(result, actualresult.Text, "Result is diffreant");
            Assert.IsTrue(actualresult.Text.Contains(result), "result is diffreant");

            //new Select(driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > span")));

        }
    }
}
