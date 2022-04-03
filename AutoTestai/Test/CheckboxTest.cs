using System;
using AutoTestai.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTestai.Test
{
    public class CheckboxTest
    {
        private static IWebDriver driver;
        private static CheckboxPage page;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-checkbox-demo.html";
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            page = new CheckboxPage(driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            page.CloseBrowser();
        }

        [Test]
        public static void TestFirstCheckbox()
        {
            page.ClickFirstChechbox();
            page.VerifyTextResult();
        }

        [Test]
        public static void TestMultipleCheckboxes()
        {
            page.CheckAllCheckboxes();
            page.VerifyButtonText();
        }

        [Test]
        public static void TestUncheckAll()
        {
            page.CheckAllCheckboxes(); //Pridedu jei noriu paleisti tik sita testa duotuoju momentu, kad uzsitikrinciau jog varneles pazymetos
            page.ClickButton();
            page.VerifyButtonText2();
        }
    }
}