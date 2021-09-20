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
    class VartuTechnikaTestas
    {
        [Test]
        public static void Testas1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://vartutechnika.lt/";
            driver.Manage().Window.Maximize();

            IWebElement inputfield1 = driver.FindElement(By.Id("doors_width"));
            string mytext1 = "2000";
            inputfield1.SendKeys(mytext1);

            IWebElement inputfield2 = driver.FindElement(By.Id("doors_height"));

            string mytext2 = "2000";

            IWebElement automatika = driver.FindElement(By.Id("automatika"));
            automatika.Click();

            inputfield2.SendKeys(mytext2);

            IWebElement coockeyreject = driver.FindElement(By.Id("cookiescript_reject"));
            coockeyreject.Click();

            IWebElement button = driver.FindElement(By.CssSelector("#calc_submit"));
            button.Click();

            //IWebElement scrollbar = driver.scr
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(e => e.FindElement(By.CssSelector("#calc_result > div")).Displayed);

            IWebElement actualresult = driver.FindElement(By.CssSelector("#calc_result > div"));

            string result = "665.98";
            Assert.IsTrue(actualresult.Text.Contains(result), $"result is not the same is {result}",result);
            Assert.IsTrue(actualresult.Text.Contains(result), "result is diffreant");

            driver.Quit();
        }

        [Test]
        public static void Testas2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://vartutechnika.lt/";
            driver.Manage().Window.Maximize();

            IWebElement inputfield1 = driver.FindElement(By.Id("doors_width"));

            string mytext1 = "4000";

            inputfield1.SendKeys(mytext1);

            IWebElement inputfield2 = driver.FindElement(By.Id("doors_height"));

            string mytext2 = "2000";

            IWebElement automatika = driver.FindElement(By.Id("automatika"));
            automatika.Click();

            IWebElement montavimoDarbas = driver.FindElement(By.Id("darbai"));
            montavimoDarbas.Click();

            inputfield2.SendKeys(mytext2);

            IWebElement coockeyreject = driver.FindElement(By.Id("cookiescript_reject"));
            coockeyreject.Click();

            IWebElement button = driver.FindElement(By.CssSelector("#calc_submit"));
            button.Click();
            //IWebElement scrollbar = driver.scr
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(e => e.FindElement(By.CssSelector("#calc_result > div")).Displayed);

            IWebElement actualresult = driver.FindElement(By.CssSelector("#calc_result > div"));

            string result = "1006.43";
            Assert.IsTrue(actualresult.Text.Contains(result), $"result is not the same is {result}", result);
            Assert.IsTrue(actualresult.Text.Contains(result), "result is diffreant");

            driver.Quit();
        }
        [Test]
        public static void Testas3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://vartutechnika.lt/";
            driver.Manage().Window.Maximize();

            IWebElement inputfield1 = driver.FindElement(By.Id("doors_width"));

            string mytext1 = "4000";

            inputfield1.SendKeys(mytext1);

            IWebElement inputfield2 = driver.FindElement(By.Id("doors_height"));

            string mytext2 = "2000";

            inputfield2.SendKeys(mytext2);

            IWebElement coockeyreject = driver.FindElement(By.Id("cookiescript_reject"));
            coockeyreject.Click();

            IWebElement button = driver.FindElement(By.CssSelector("#calc_submit"));
            button.Click();
            //IWebElement scrollbar = driver.scr
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(e => e.FindElement(By.CssSelector("#calc_result > div")).Displayed);

            IWebElement actualresult = driver.FindElement(By.CssSelector("#calc_result > div"));

            string result = "692.35";
            Assert.IsTrue(actualresult.Text.Contains(result), $"result is not the same is {result}", result);
            Assert.IsTrue(actualresult.Text.Contains(result), "result is diffreant");

            driver.Quit();
        }
        [Test]
        public static void Testas4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://vartutechnika.lt/";
            driver.Manage().Window.Maximize();

            IWebElement inputfield1 = driver.FindElement(By.Id("doors_width"));

            string mytext1 = "5000";

            inputfield1.SendKeys(mytext1);

            IWebElement inputfield2 = driver.FindElement(By.Id("doors_height"));

            string mytext2 = "2000";

            inputfield2.SendKeys(mytext2);

            IWebElement montavimoDarbas = driver.FindElement(By.Id("darbai"));
            montavimoDarbas.Click();

            IWebElement coockeyreject = driver.FindElement(By.Id("cookiescript_reject"));
            coockeyreject.Click();

            IWebElement button = driver.FindElement(By.CssSelector("#calc_submit"));
            button.Click();
            //IWebElement scrollbar = driver.scr
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(e => e.FindElement(By.CssSelector("#calc_result > div")).Displayed);

            IWebElement actualresult = driver.FindElement(By.CssSelector("#calc_result > div"));

            string result = "989.21";
            Assert.IsTrue(actualresult.Text.Contains(result), $"result is not the same is {result}", result);
            Assert.IsTrue(actualresult.Text.Contains(result), "result is diffreant");

            driver.Quit();
        }
    }

}