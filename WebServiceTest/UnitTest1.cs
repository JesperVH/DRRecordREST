using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;


namespace WebServiceTest
{
    [TestClass]
    public class UnitTest1
    {

        private static readonly string DriverDirectory = "C:\\SeleniumDrivers";
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void TestMethod1()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            _driver.Navigate().GoToUrl("http://localhost:3000/");
            Assert.AreEqual("DR Record Service", _driver.Title);

            //IWebElement inputElement = _driver.FindElement(By.Id("inputField"));
            //inputElement.SendKeys("Anders");
            

            IWebElement buttonElement = _driver.FindElement(By.Id("GetAllButton"));
            buttonElement.Click();


            IWebElement ding = wait.Until(ExpectedConditions.ElementExists(By.Id("recordlist")));
            var outputElement = _driver.FindElements(By.Id("recordlist"));
            string text = outputElement[0].Text;
             Assert.AreEqual("Coopers Rum Ye Banished Privateers 3.22 2017", text);
            
        }
    }
}
