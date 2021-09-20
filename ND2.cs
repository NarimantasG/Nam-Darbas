using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;

namespace AutomatinisTestavimas
{
    class ND2
    {
        [Test]
        public static void testChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();
            driver.Quit();
        }
        [Test]
        public static void testFirefox()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();
            driver.Quit();
        }
        [Test]
        public static void testOpera()
        {
            IWebDriver driver = new OperaDriver();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();
            driver.Quit();
        }
        [Test]
        public static void testEdge()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();
            driver.Quit();
        }
        [Test]
        public static void distancepace()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.active.com/fitness/calculators/pace";
            driver.Manage().Window.Maximize();

            IWebElement timeH = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(1) > input[type=number]"));
            string TimeH = "1";
            timeH.SendKeys(TimeH);

            IWebElement timeM = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(2) > input[type=number]"));
            string TimeM = "5";
            timeM.SendKeys(TimeM);

            IWebElement distance = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > label > input[type=number]"));
            string Distance = "13";
            distance.SendKeys(Distance);

            IWebElement calculate = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(6) > div > a"));
            calculate.Click();

            IWebElement PaceMin = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(4) > div > label:nth-child(2) > input[type=number]"));
            string result = "";

            Assert.AreEqual(result, PaceMin.Text, "Result is diffreant");
            Assert.IsTrue(PaceMin.Text.Contains(result), "result is diffreant");

            driver.Quit();

        }
    }
}
