using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace NUnitTestProject3
{
    public class Tests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private MainPage mainPage;
        private LogoutPage logoutPage;


        protected const string name = "user";
        protected const string password = "user";

        [OneTimeSetUp]
        public void TestFixture()
        {
            driver = new ChromeDriver();
        }

        [SetUp]
        public void OneTimeSetUp()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [Test, Order(1)]
        public void Login()
        {
            loginPage = new LoginPage(driver);
            loginPage.Login(name, password);
            Assert.AreEqual("Home page", driver.FindElement(By.XPath("//div[h2= 'Home page']")).Text);
        }

        [Test, Order(2)]
        public void AddProduct()
        {
            mainPage = new MainPage(driver);
            mainPage.AddProduct();
            Thread.Sleep(2000);
            Assert.AreEqual("Test", driver.FindElement(By.XPath("//a[contains(text(), 'Test')]")).Text);
        }

        [Test, Order(3)]
        public void Logout()
        {
            logoutPage = new LogoutPage(driver);
            logoutPage.Logout();
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//div[h2= 'Login']")).Text);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }

    }
}

