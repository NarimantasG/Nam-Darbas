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
    class Komandos
    {
        [Test]
        public static void items()
        {
            // open website
            IWebDriver driver = new ChromeDriver();
            driver.Url = "";
            driver.Manage().Window.Maximize();

            //laukia 10s
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //suranda išsokančios reklamos elementa
            IWebElement popup = driver.FindElement(By.Id(""));

            //Laukia kol langas atsidaro
            wait.Until(e => e.FindElement(By.Id("")).Displayed);

            //uždaro išsokanti langa
            popup.Click();

            //Randa svetaines elementa
            IWebElement button = driver.FindElement(By.CssSelector(""));




            button.GetAttribute("value").Equals("Check All");

        }
    }
}
