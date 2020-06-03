using NUnitTestProject3.busness_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using System.Security.Cryptography.X509Certificates;

namespace NUnitTestProject3.step_definitions
{
    [Binding]
    class ProductSteps
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIopenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
            driver.Navigate().GoToUrl(url);
        }

        [When(@"I type my value Name and Pussword")]
        public void WhenITypeMyValueNameAndPussword(string name, string pussword)
        {
            new LoginPage(driver).Login(new LoginValue(name, pussword));
        }

        [When(@"I click button ""(.*)"" Login")]
        public void IClickButtonEnerLogin()
        {
            new LoginPage(driver).LoginSend();
        }

        [When(@"I click on the link All Product ")]
            public void IClickOnTheLinkAllProduct()
        {
            new MainPage(driver).ClickAllProduct();
        }

        [When(@"I click the Create new button")]
        public void ICkickTheCreateNewButton()
        {
            new MainPage(driver).ClickCreateNewButton();
        }

        [When(@"I type ""(.*)"" ProductName")]
        public void IFillProductNameField(string ProductName)
        {
            new MainPage(driver).SendName(new Product(ProductName, null, null, null, null, null));
        }

        [When(@"I pick Category")]
        public void IPickCategory()
        {
            new MainPage(driver).Category();
        }

        [When(@"I pick Supplier")]
        public void IPickSupplier()
        {
            new MainPage(driver).Supplier();
        }

        [When(@"I fill fields ""(.*)"" UnitPrice, ""(.*)"" QuantityPerUnit, ""(.*)"" UnitsInStock, ""(.*)"" UnitsOnOrder, ""(.*)"" ReorderLevel")]
        public void IFillFields(string UnitPrice, string QuantityPerUnit, string UnitsInStock, string UnitsOnOrder, string ReorderLevel)
        {
            new MainPage(driver).Field(new Product(null, UnitPrice, QuantityPerUnit, UnitsInStock, UnitsOnOrder, ReorderLevel));
        }

        [When(@"I click button Enter Product")]
        public void IClickButtonEnterProduct()
        {
            new MainPage(driver).AddProduct();
        }

        [Then(@"I check that Anything product has been created")]
        public void ICheckThatAnythingProductHasBeenCreated(string ProductName)
        {
            new MainPage(driver).AssertProduct(new Product(ProductName, null, null, null, null, null));

            MainPage mainPage = new MainPage(driver);
            Assert.AreEqual(ProductName, mainPage.AssertProduct(new Product(ProductName, null, null, null, null, null)));
        }
    }
}
