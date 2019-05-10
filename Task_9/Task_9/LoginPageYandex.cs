using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class LoginPageYandex
    {
        By usernameLocator = By.XPath("//input[@type='text']");
        By passwordLocator = By.XPath("//input[@type='password']");
        By loginButtonLocator = By.XPath("//button[@type='submit']");
        WebDriverWait wait;
        IWebElement element;

        private ChromeDriver driver;

        public LoginPageYandex(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
            driver.Navigate().GoToUrl("https://passport.yandex.by/auth?origin=home_desktop_by&retpath=https%3A%2F%2Fmail.yandex.by%2F%2F%3Fmsid%3D1557432183.7944.122076.126389%26m_pssp%3Ddomik&backpath=https%3A%2F%2Fyandex.by");
        }

        public LoginPageYandex typeUsername(string username)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(usernameLocator));
            element = wait.Until(r => driver.FindElement(usernameLocator));
            driver.FindElement(usernameLocator).SendKeys(username);

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            //element.FindElement(usernameLocator).SendKeys(username);
            return this;
        }

        public LoginPageYandex typePassword(string password)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(passwordLocator));
            element = wait.Until(r => driver.FindElement(passwordLocator));
            element.FindElement(passwordLocator).SendKeys(password);
            return this;
        }

        public YandexHomePage submitLogin()
        {
            driver.FindElement(loginButtonLocator).Submit();
            return new YandexHomePage(driver);
        }

        public YandexHomePage loginAs(string username, string password)
        {
            typeUsername(username);
            typePassword(password);
            return submitLogin();
        }
    }
}
