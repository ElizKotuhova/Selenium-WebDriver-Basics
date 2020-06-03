﻿using NUnitTestProject3.busness_object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject3
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement clickName => driver.FindElement(By.XPath("//input[@id='Name']"));
        private IWebElement clickPussword => driver.FindElement(By.XPath("//input[@id='Password']"));
        private IWebElement assertLogin => driver.FindElement(By.XPath("//div[h2= 'Home page']"));

        public LoginPage Login(LoginValue loginValue)
        {
            new Actions(driver).Click(clickName).SendKeys(loginValue.name).Build().Perform();
            new Actions(driver).Click(clickPussword).SendKeys(loginValue.pussword).Build().Perform();
            return new LoginPage(driver);
        }
        public LoginPage LoginSend()
        {
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
            return this;
        }
        public string AssertLogin()
        {
            return assertLogin.Text;
        }
    }
}
