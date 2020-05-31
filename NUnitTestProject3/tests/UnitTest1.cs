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
        private LoginPage loginPage;
        private MainPage mainPage;
        private LogoutPage logoutPage;

        private LoginValue loginValue = new LoginValue("user", "user");
        

        [Test, Order(1)]
        public void Login()
        {
            //LoginPage loginPage = new LoginPage(driver);
            //loginPage = loginPage.Login(loginValue);

            loginPage = new ProductService.Add(driver, loginValue);
            Assert.That(loginPage.AssertLogin, Is.EqualTo("Home page"));
        }

        [Test, Order(2)]
        public void AddProductTest() 
        {
            //MainPage mainPage = new MainPage(driver);
            //mainPage.AddProduct(driver);

            mainPage = new ProductService.Add(driver, product);
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

