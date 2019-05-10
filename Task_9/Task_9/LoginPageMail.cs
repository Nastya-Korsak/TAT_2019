using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_9
{
    class LoginPageMail
    {
        By usernameLocator = By.XPath("//input[@id='mailbox:login']");
        By passwordLocator = By.XPath("//input[@id='mailbox:password']");
        By loginButtonLocator = By.XPath("//input[@class='o-control']");
        WebDriverWait wait;
        IWebElement element;

        private ChromeDriver driver;

    public LoginPageMail(ChromeDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("https://mail.ru/");
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
        }

        public LoginPageMail typeUsername(string username)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(usernameLocator));
            element = wait.Until(r => driver.FindElement(usernameLocator));
            element.FindElement(usernameLocator).SendKeys(username);
            return this;
        }

        public LoginPageMail typePassword(string password)
        {
            element = wait.Until(r => driver.FindElement(passwordLocator));
            element.FindElement(passwordLocator).SendKeys(password);
            return this;
        }

        public MailHomePage submitLogin()
        {
            driver.FindElement(loginButtonLocator).Submit();
            return new MailHomePage(driver);
        }

        public MailHomePage loginAs(string username, string password)
        {
            typeUsername(username);
            typePassword(password);
            return submitLogin();
        }
    }
}
