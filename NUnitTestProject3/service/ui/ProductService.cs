using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitTestProject3.busness_object;

namespace NUnitTestProject3.service.ui
{
    public class ProductService 
    { 
        public static MainPage Add(MainPage AddProduct, IWebDriver driver)
        { 
            MainPage mainPage = new MainPage(driver);
            mainPage.AddProduct();
            return new MainPage(driver);
        }
    }
}
