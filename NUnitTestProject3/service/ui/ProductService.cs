using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitTestProject3.busness_object;
using System.Runtime.CompilerServices;

namespace NUnitTestProject3.service.ui
{
    public class ProductService 
    {
        public void Add(IWebDriver driver, Product product, LoginValue loginValue)
        {
            LoginPage loginPage = new LoginPage(driver);           
            loginPage.Login(loginValue);

            MainPage mainPage = new MainPage(driver);
            mainPage.AddProduct(product);            
        }
    }
}
