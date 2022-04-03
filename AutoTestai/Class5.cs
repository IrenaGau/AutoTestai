//ND2, 2 paskaita, 2022 04 01

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace AutoTestai
{
    internal class Class5
    {
        private static IWebDriver driver;

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }

        [Test]
        public static void TestWithFirefox()
        {
            driver = new FirefoxDriver();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();

            IWebElement resultElement = driver.FindElement(By.CssSelector ("#primary-detection > div"));
            Assert.IsTrue("Firefox 98 on Windows 10".Equals(resultElement.Text), $"Text is not the same, actual text is {resultElement.Text}");
            
            //driver.Quit();
        }
        
        [Test]
        public static void TestWithChrome()
        {
            driver = new ChromeDriver();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();

            IWebElement resultElement = driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.IsTrue("Chrome 99 on Windows 10".Equals(resultElement.Text), $"Text is not the same, actual text is {resultElement.Text}");

            //driver.Quit();
        }

        [Test]
        public static void TestWithEdge()
        {
            driver = new EdgeDriver();
            driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();

            IWebElement resultElement = driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.IsTrue("Edge 99 on Windows 10".Equals(resultElement.Text), $"Text is not the same, actual text is {resultElement.Text}");

            //driver.Quit();
        }

    }
}

