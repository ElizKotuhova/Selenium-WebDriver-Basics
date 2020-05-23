using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject3
{
    class MainPage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver deriver)
        {
            this.driver = driver;
        }
        private IWebElement searchkdiv => driver.FindElement(By.XPath("//div[h2= 'Home page']//preceding::a[@href = '/Product']"));
        private IWebElement searcha => driver.FindElement(By.XPath("//a[@class = 'btn btn-default']"));
        private IWebElement searchinput => driver.FindElement(By.XPath("//input[@id = 'ProductName']"));
        private IWebElement searchinput1 => driver.FindElement(By.XPath("//input[@id = 'ProductName']"));
        private IWebElement searchselect => driver.FindElement(By.XPath("//select[@id= 'CategoryId']"));
        private IWebElement searchselect1 => driver.FindElement(By.XPath("//select[@id= 'CategoryId']/child::option[@value = '1']"));
        private IWebElement searchselect2 => driver.FindElement(By.XPath("//select[@id= 'SupplierId']"));
        private IWebElement searchselect3 => driver.FindElement(By.XPath("//select[@id= 'SupplierId']/child::option[@value = '1']"));
        private IWebElement searchinput2 => driver.FindElement(By.XPath("//input[@id = 'UnitPrice']"));
        private IWebElement searchinput3 => driver.FindElement(By.XPath("//input[@id = 'UnitPrice']"));
        private IWebElement searchinput4 => driver.FindElement(By.XPath("//input[@id = 'QuantityPerUnit']"));
        private IWebElement searchinput5 => driver.FindElement(By.XPath("//input[@id = 'QuantityPerUnit']"));
        private IWebElement searchinput6 => driver.FindElement(By.XPath("//input[@id = 'QuantityPerUnit']"));
        private IWebElement searchinput7 => driver.FindElement(By.XPath("//input[@id = 'UnitsInStock']"));
        private IWebElement searchinput8 => driver.FindElement(By.XPath("//input[@id = 'UnitsInStock']"));
        private IWebElement searchinput9 => driver.FindElement(By.XPath("//input[@id = 'UnitsOnOrder']"));
        private IWebElement searchinput10 => driver.FindElement(By.XPath("//input[@id = 'UnitsOnOrder']"));
        private IWebElement searchinput11 => driver.FindElement(By.XPath("//input[@id = 'ReorderLevel']"));
        private IWebElement searchinput12 => driver.FindElement(By.XPath("//input[@id = 'ReorderLevel']"));
        private IWebElement searchinput13 => driver.FindElement(By.XPath("//input[@type = 'submit']"));


        private IWebElement searchinputlogout => driver.FindElement(By.XPath("//a[@href= '/Account/Logout']"));

        public void SearchProduct(string product)
        {

            searchkdiv.Click();
            searcha.Click();
            searchinput.Click();
            searchinput1.SendKeys("Test");
            searchselect.Click();
            searchselect1.Click();
            searchselect2.Click();
            searchselect3.Click();
            searchinput2.Click();
            searchinput3.SendKeys("12");
            searchinput4.Click();
            searchinput5.SendKeys("1");
            searchinput6.Click();
            searchinput7.SendKeys("1");
            searchinput8.Click();
            searchinput9.SendKeys("1");

            //searchinput10.Click();
            //searchinput11.SendKeys("1");
            new Actions(driver).Click(searchinput10).SendKeys("1").Build().Perform();

            //searchinput12.Click();
            //searchinput13.SendKeys("1");
            new Actions(driver).Click(searchinput13).SendKeys("1").Build().Perform();

            searchinputlogout.Click();
        }

    }
}
