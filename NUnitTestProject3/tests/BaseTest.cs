using NUnit.Framework;
using OpenQA.Selenium;
using NUnitTestProject3.busness_object;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject3.tests
{
    public class BaseTest
    {
        protected private IWebDriver driver;
        protected private string baseUrl;

        [OneTimeSetUp]
        public void TestFixture()
        {
            driver = new ChromeDriver();
        }

        [SetUp]
        public void OneTimeSetUp()
        {
        baseUrl = "http://localhost:5000/";
        driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
        driver.Close();
        driver.Quit();
        }
    }

    
}
