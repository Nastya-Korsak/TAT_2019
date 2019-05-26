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
    public class MailHomePage
    {
        By newLetterButtonLocator = By.XPath("//span[contains(.,'Написать письмо')]");
        By usernameLocator = By.XPath("//textarea[@tabindex='4']");
        By letterLocator = By.XPath(".//tr[@class='mceFirst mceLast']//iframe");
        By sendMessengerLocator = By.XPath("//div[@data-name = 'send'][1]");
        By openMassengLocator = By.XPath("//div[@class='b-datalist__body']/div[1]");
        By copyMassengLocator = By.XPath("//div[@class = 'js-helper js-readmsg-msg']//div//div//div");

        WebDriverWait wait;
        IWebElement element;

        private ChromeDriver driver;

        public MailHomePage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
        }

        public MailHomePage submitNewLetter()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(newLetterButtonLocator));
            element = wait.Until(r => driver.FindElement(newLetterButtonLocator));
            element.Click();
            return this;
        }

        public MailHomePage typeAddresee(string username)
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(newLetterButtonLocator));
            element = wait.Until(r => driver.FindElement(usernameLocator));
            element.SendKeys(username);
            return this;
        }

        public MailHomePage typeLetter(string letter)
        {
            driver.SwitchTo().Frame(driver.FindElement(letterLocator));
            driver.FindElement(By.Id("tinymce")).Click();
            driver.FindElement(By.Id("tinymce")).Clear();
            driver.FindElement(By.Id("tinymce")).SendKeys(letter);
            driver.SwitchTo().DefaultContent();
            return this;
        }

        public MailHomePage clickSendMessenger()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(sendMessengerLocator));
            element = wait.Until(r => driver.FindElement(sendMessengerLocator));
            element.Click();
            return this;
        }

        public void SendMasseng (string mail,string letter)
        {
            submitNewLetter();
            typeAddresee(mail);
            typeLetter(letter);
            clickSendMessenger();
        }

        public MailHomePage openMasseng()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(openMassengLocator));
            element = wait.Until(r => driver.FindElement(openMassengLocator));
            element.FindElement(openMassengLocator).Click();
            return this;
        }

        public string copyMessege()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(copyMassengLocator));
            element = wait.Until(r => driver.FindElement(copyMassengLocator));
            return element.FindElement(copyMassengLocator).Text;
        }

        public MailChangNamePage goToChangNamePaege()
        {
            return new MailChangNamePage(driver);
        }
    }
}
