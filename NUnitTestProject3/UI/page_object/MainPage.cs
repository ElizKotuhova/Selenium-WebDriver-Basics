using NUnitTestProject3.busness_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NUnitTestProject3
{
    public class MainPage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement clickProduct => driver.FindElement(By.XPath("//div[h2= 'Home page']//preceding::a[@href = '/Product']"));
        private IWebElement clickCreateNew => driver.FindElement(By.XPath("//a[@class = 'btn btn-default']"));
        private IWebElement sendkeysProductName => driver.FindElement(By.XPath("//input[@id = 'ProductName']"));
        private IWebElement clickCategory => driver.FindElement(By.XPath("//select[@id= 'CategoryId']"));
        private IWebElement sendkeysCategory => driver.FindElement(By.XPath("//select[@id= 'CategoryId']/child::option[@value = '1']"));
        private IWebElement clickSupplier => driver.FindElement(By.XPath("//select[@id= 'SupplierId']"));
        private IWebElement sendkeysSupplier => driver.FindElement(By.XPath("//select[@id= 'SupplierId']/child::option[@value = '1']"));
        private IWebElement sendkeysUnitPrice => driver.FindElement(By.XPath("//input[@id = 'UnitPrice']"));
        private IWebElement sendkeysQuantityPerUnit => driver.FindElement(By.XPath("//input[@id = 'QuantityPerUnit']"));
        private IWebElement sendkeysUnitInStock => driver.FindElement(By.XPath("//input[@id = 'UnitsInStock']"));
        private IWebElement sendkeysUnitsOnOrder => driver.FindElement(By.XPath("//input[@id = 'UnitsOnOrder']"));
        private IWebElement sendkeysReorderLevel => driver.FindElement(By.XPath("//input[@id = 'ReorderLevel']"));
        private IWebElement assertProduct => driver.FindElement(By.XPath("//div[h2='All Products']"));

        public void ClickAllProduct()
        {
            clickProduct.Click();
        }
        public void ClickCreateNewButton()
        {
            clickCreateNew.Click();
        }
        public void SendName(Product product)
        {
            sendkeysProductName.SendKeys(product.sendkeysProductName);
        }
        public void Category()
        {
            new Actions(driver).Click(clickCategory).Build().Perform();
            sendkeysCategory.Click();
        }
        public void Supplier()
        {
            new Actions(driver).Click(clickSupplier).Build().Perform();
            sendkeysSupplier.Click();
        }
        public void Field(Product product)
        {
            sendkeysUnitPrice.SendKeys(product.sendkeysUnitPrice);
            sendkeysQuantityPerUnit.SendKeys(product.sendkeysQuantityPerUnit);
            sendkeysUnitInStock.SendKeys(product.sendkeysUnitInStock);
            sendkeysUnitsOnOrder.SendKeys(product.sendkeysUnitsOnOrder);
            sendkeysReorderLevel.SendKeys(product.sendkeysReorderLevel);
        }
        public void AddProduct()
        {
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }

        public string AssertProduct(Product product)
        {
            IWebElement assertProduct = driver.FindElement(By.XPath($"//*[text()=\"{product.sendkeysProductName}\"]"));
            return assertProduct.Text;
        }
    }
}
