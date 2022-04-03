
//Namu darbai 1 paskaita
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;

namespace AutoTestai
{
    internal class NDpaskaita1
    {
        [Test]
        public static void TestKai2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();


            string No1 = "2";
            IWebElement inputField1 = driver.FindElement(By.CssSelector("#sum1"));
            inputField1.SendKeys(No1); //klausimas kaip Sendkeys daryti jei noriu naudoti ne string tipo kontamaji
           

            string No2 = "2";
            IWebElement inputField2 = driver.FindElement(By.CssSelector("#sum2"));
            inputField2.SendKeys(No2);


            IWebElement button = driver.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();


            IWebElement resultElement = driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("4", resultElement.Text, "Text is wrong"); //Tik nezinau kaip sioje vietoje expected pasirasyti teisingiausia kai turime 2 ivedimo laukus

            driver.Quit();

        }

        [Test]
        public static void TestKaiMinus5Ir3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();


            string No1 = "-5";
            IWebElement inputField1 = driver.FindElement(By.CssSelector("#sum1"));
            inputField1.SendKeys(No1); 

            string No2 = "3";
            IWebElement inputField2 = driver.FindElement(By.CssSelector("#sum2"));
            inputField2.SendKeys(No2);


            IWebElement button = driver.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();

            int suma = -5 + 3;
            IWebElement resultElement = driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(suma.ToString(), resultElement.Text, "Text is wrong");

            driver.Quit();

        }

        [Test]
        public static void TestKaiAB()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.seleniumeasy.com/basic-first-form-demo.html";
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("at-cv-lightbox-close")).Click();


            string No1 = "a";
            IWebElement inputField1 = driver.FindElement(By.CssSelector("#sum1"));
            inputField1.SendKeys(No1);

            string No2 = "b";
            IWebElement inputField2 = driver.FindElement(By.CssSelector("#sum2"));
            inputField2.SendKeys(No2);


            IWebElement button = driver.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();


            IWebElement resultElement = driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("NaN", resultElement.Text, "Text is wrong");

            driver.Quit();



        }
    }
}
