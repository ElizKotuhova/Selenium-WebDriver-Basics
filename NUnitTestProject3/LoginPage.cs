using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject3
{
    class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement clickName => driver.FindElement(By.XPath("//input[@id='Name']"));
        private IWebElement clickPussword => driver.FindElement(By.XPath("//input[@id='Password']"));
        private IWebElement assertLogin => driver.FindElement(By.XPath("//div[h2= 'Home page']"));

        public void Login(string name, string pussword)
        {
            new Actions(driver).Click(clickName).SendKeys(name).Build().Perform();
            new Actions(driver).Click(clickPussword).SendKeys(pussword).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
        public string AssertLogin()
        {
            return assertLogin.Text;
        }
    }
}
