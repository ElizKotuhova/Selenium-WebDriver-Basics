using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitTestProject3.busness_object;

namespace NUnitTestProject3.service.ui
{
    public class ProductService 
    { 
        public static void Add(MainPage AddProduct, IWebDriver driver, Product product, LoginPage value, LoginValue loginValue)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login(loginValue);

            MainPage mainPage = new MainPage(driver);
            mainPage.AddProduct(product);
        }
    }
}
