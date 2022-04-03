//Paskaita 2

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTestai
{
    internal class Class4
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-checkbox-demo.html";
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }

        [Test]
        public static void TestCheckbox()
        {

            IWebElement Checkbox = driver.FindElement(By.Id("isAgeSelected"));
            Checkbox.Click();

            string ats = "Success - Check box is checked";
            IWebElement Rezult = driver.FindElement(By.Id("txtAge"));
            Assert.AreEqual(ats, Rezult.Text, "Ivyko klaida");


        }
        
    }
}
