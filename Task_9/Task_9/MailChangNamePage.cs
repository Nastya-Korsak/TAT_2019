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
    class MailChangNamePage
    {
        By changeNameLocator = By.XPath("//input[@name='FirstName']");
        By saveChangesLocator = By.XPath("//span[contains(.,'Сохранить')]");
        WebDriverWait wait;
        IWebElement element;

        private ChromeDriver driver;

        public MailChangNamePage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
            driver.Navigate().GoToUrl("https://e.mail.ru/settings/userinfo");
        }

        public void changeName(string name)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(changeNameLocator));
            driver.FindElement(changeNameLocator);
            driver.FindElement(changeNameLocator).Click();
            driver.FindElement(changeNameLocator).Clear();
            driver.FindElement(changeNameLocator).SendKeys(name);
        }

        public void saveChanges()
        {
            driver.FindElement(saveChangesLocator);
            driver.FindElement(saveChangesLocator).Click();
        }
    }
}
