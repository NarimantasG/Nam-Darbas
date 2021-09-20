using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisTestavimas
{
    class SingleFormDemoTest
    {
        [Test]
        public static void TestSingleInputField()
        {
            //Pakelia browser
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //suranda issokancios reklamos elementa
            IWebElement popup = driver.FindElement(By.Id("at-cv-lightbox-close"));


            wait.Until(e => e.FindElement(By.Id("at-cv-lightbox-close")).Displayed);
            popup.Click();

            //Susiranda elementa
            IWebElement inputField = driver.FindElement(By.Id("user-message"));
            //Tekstas kuris bus yrasomas i "inputField"
            string MyText = "hello";
            //iraso teksta i input fielda
            inputField.SendKeys(MyText);

            //Susiranda elementa
            IWebElement showMessageButton = driver.FindElement(By.CssSelector("#get-input > button"));

            showMessageButton.Click();


            //uzdaro draiveri
            driver.Quit();
        } 
        [Test]
        public static void TestFieldsSum()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
            IWebElement inputField1 = driver.FindElement(By.Id("sum1"));

            string MyText1 = "2";

            inputField1.SendKeys(MyText1);


            IWebElement inputField2 = driver.FindElement(By.Id("sum2"));

            string MyText2 = "2";

            inputField2.SendKeys(MyText2);

            IWebElement GetTotalButton = driver.FindElement(By.CssSelector("#gettotal > button"));
            GetTotalButton.Click();
            //suranda issokancios reklamos elementa
            IWebElement popup = driver.FindElement(By.Id("at-cv-lightbox-close"));
            popup.Click();

            //uzdaro draiveri
            driver.Quit();
        }
        [Test]
        public static void TestFieldsSum2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
            IWebElement inputField1 = driver.FindElement(By.Id("sum1"));

            string MyText1 = "-5";

            inputField1.SendKeys(MyText1);
            //suranda issokancios reklamos elementa
            IWebElement popup = driver.FindElement(By.Id("at-cv-lightbox-close"));
            popup.Click();

            IWebElement inputField2 = driver.FindElement(By.Id("sum2"));

            string MyText2 = "3";

            inputField2.SendKeys(MyText2);
            IWebElement GetTotalButton = driver.FindElement(By.CssSelector("#gettotal > button"));
            GetTotalButton.Click();
            IWebElement ActualResult = driver.FindElement(By.Id("displayvalue"));

            string result = "-2";

            Assert.AreEqual(result, ActualResult.Text, "Result is diffreant");
            Assert.IsTrue(ActualResult.Text.Contains(result), "result is diffreant");

            inputField1.Clear();
            inputField2.Clear();
            //uzdaro draiveri
            driver.Quit();
        }
        [Test]
        public static void TestFieldsSum3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
            IWebElement inputField1 = driver.FindElement(By.Id("sum1"));

            string MyText1 = "a";

            inputField1.SendKeys(MyText1);
            //suranda issokancios reklamos elementa
            IWebElement popup = driver.FindElement(By.Id("at-cv-lightbox-close"));
            popup.Click();
            IWebElement inputField2 = driver.FindElement(By.Id("sum2"));

            string MyText2 = "b";

            inputField2.SendKeys(MyText2);
            IWebElement GetTotalButton = driver.FindElement(By.CssSelector("#gettotal > button"));
            GetTotalButton.Click();
            IWebElement ActualResult = driver.FindElement(By.Id("displayvalue"));

            string result = "NaN";

            Assert.AreEqual(result, ActualResult.Text, "Result is diffreant");
            Assert.IsTrue(ActualResult.Text.Contains(result), "result is diffreant");

            inputField1.Clear();
            inputField2.Clear();
            //uzdaro draiveri
            driver.Quit();

        }
        [Test]
        public static void browsertest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();

            //driver.Quit();
        }
    }
}
