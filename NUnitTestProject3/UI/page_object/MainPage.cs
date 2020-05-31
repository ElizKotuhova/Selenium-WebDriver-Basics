using NUnitTestProject3.busness_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
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

        public void AddProduct(Product product)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            new Actions(driver).Click(clickProduct).SendKeys(product.clickProduct).Build().Perform();
            new Actions(driver).Click(clickCreateNew).SendKeys(product.clickCreateNew).Build().Perform();
            new Actions(driver).Click(sendkeysProductName).SendKeys(product.sendkeysProductName).Build().Perform();
            new Actions(driver).Click(clickCategory).SendKeys(product.clickCategory).Build().Perform();
            sendkeysCategory.Click();
            new Actions(driver).SendKeys(product.clickSupplier).Build().Perform();
            sendkeysSupplier.Click();
            new Actions(driver).SendKeys(product.sendkeysUnitPrice).SendKeys("12").Build().Perform();
            new Actions(driver).SendKeys(product.sendkeysQuantityPerUnit).SendKeys("1").Build().Perform();
            new Actions(driver).SendKeys(product.sendkeysUnitInStock).SendKeys("1").Build().Perform();
            new Actions(driver).SendKeys(product.sendkeysUnitsOnOrder).SendKeys("1").Build().Perform();
            new Actions(driver).SendKeys(product.sendkeysReorderLevel).SendKeys("1").Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
        public string AssertProduct()
        {
            return assertProduct.Text;
        }

    }
}
