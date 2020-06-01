using NUnit.Framework;
using NUnitTestProject3.busness_object;
using NUnitTestProject3.service.ui;
using NUnitTestProject3.tests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace NUnitTestProject3
{
    public class Tests : BaseTest
    {
        private MainPage mainPage;
        private LogoutPage logoutPage;

        private LoginValue loginValue = new LoginValue("user", "user");
        private Product product = new Product("Anything", "12", "1", "1", "1", "1");

        [Test, Order(1)]
        public void Login()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage = loginPage.Login(loginValue);

            Assert.That(loginPage.AssertLogin, Is.EqualTo("Home page"));
        }

        [Test, Order(2)]
        public void AddProductTest() 
        {
            mainPage = ProductService.AddProduct(driver, product);
            Assert.That(mainPage.AssertProduct, Is.EqualTo("All Products"));
        }

        [Test, Order(3)]
        public void Logout()
        {
            logoutPage = new LogoutPage(driver);
            logoutPage.Logout();

            Assert.That(logoutPage.AssertLogout, Is.EqualTo("Login"));
        }
    }
}

