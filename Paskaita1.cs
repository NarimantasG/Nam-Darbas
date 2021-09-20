using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatinisTestavimas
{
    public class Paskaita1
    {
        //4 yra lyginis skaicius
        //Dabar 19 valanda

        [Test]
        public static void TestIf4IsEven()
        {
            int leftover = 4 % 2;
            Assert.AreEqual(0, leftover, "4 is not even");
        }

        [Test]
        public static void Ar20Valanda()
        {
            DateTime Laikas = DateTime.Now;
            Assert.AreEqual(20, Laikas.Hour, "laikas yra 20");

        }
        [Test]
        public static void TestIf995IsEven()
        {
            int leftover = 995 % 2;
            Assert.AreEqual(0, leftover, "4 is not even");
        }
        [Test]
        public static void TestFromDriver()
        {
            IWebDriver driver = new ChromeDriver();
            //driver.Url = "https://login.yahoo.com/";
            driver.Url = "http://vartutechnika.lt/";
            driver.Manage().Window.Maximize();
            driver.Quit();

        }
    }
}
