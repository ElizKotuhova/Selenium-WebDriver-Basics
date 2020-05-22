using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace NUnitTestProject3
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void TestFixture()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [SetUp]
        public void Login()
        {
            driver.FindElement(By.XPath("//input[@id='Name']")).Click();
            driver.FindElement(By.XPath("//input[@id='Name']")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@id='Password']")).Click();
            driver.FindElement(By.XPath("//input[@id='Password']")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("Home page", driver.FindElement(By.XPath("//div[h2= 'Home page']")).Text);
                  
            driver.FindElement(By.XPath("//div[h2= 'Home page']//preceding::a[@href = '/Product']")).Click();
            driver.FindElement(By.XPath("//a[@class = 'btn btn-default']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'ProductName']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'ProductName']")).SendKeys("Test");
            driver.FindElement(By.XPath("//select[@id= 'CategoryId']")).Click();
            driver.FindElement(By.XPath("//select[@id= 'CategoryId']/child::option[@value = '1']")).Click();
            driver.FindElement(By.XPath("//select[@id= 'SupplierId']")).Click();
            driver.FindElement(By.XPath("//select[@id= 'SupplierId']/child::option[@value = '1']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'UnitPrice']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'UnitPrice']")).SendKeys("12");
            driver.FindElement(By.XPath("//input[@id = 'QuantityPerUnit']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'QuantityPerUnit']")).SendKeys("1");
            driver.FindElement(By.XPath("//input[@id = 'UnitsInStock']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'UnitsInStock']")).SendKeys("1");
            driver.FindElement(By.XPath("//input[@id = 'UnitsOnOrder']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'UnitsOnOrder']")).SendKeys("1");
            driver.FindElement(By.XPath("//input[@id = 'ReorderLevel']")).Click();
            driver.FindElement(By.XPath("//input[@id = 'ReorderLevel']")).SendKeys("1");
            driver.FindElement(By.XPath("//input[@type = 'submit']")).Click();

            Assert.AreEqual("Test", driver.FindElement(By.XPath("//a[@href = '/Product/Edit?ProductId=96']")).Text);           
        }

        [Test]
        public void Logout()
        {
            driver.FindElement(By.XPath("//a[@href= '/Account/Logout']")).Click();
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//div[h2= 'Login']")).Text);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }

    }
}