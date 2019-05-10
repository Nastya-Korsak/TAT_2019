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
    class YandexHomePage
    {
       
        By openMassengLocator = By.XPath("//div[@class='ns-view-container-desc mail-MessagesList js-messages-list']/div[1]");
        By answerLocator = By.XPath("//span[contains(.,'Ответить')]");
        By letterLocator = By.XPath("//div[@class='cke_wysiwyg_div cke_reset cke_enable_context_menu cke_editable cke_editable_themed cke_contents_ltr cke_show_borders']");
        By sendMessengerLocator = By.XPath("//button[@id='nb-17']");

        WebDriverWait wait;
        IWebElement element;

        private ChromeDriver driver;

        public YandexHomePage(ChromeDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(2));
        }

        public YandexHomePage openMasseng()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(openMassengLocator));
            element = wait.Until(r => driver.FindElement(openMassengLocator));
            element.FindElement(openMassengLocator).Click();
            return this;
        }

        public YandexHomePage answerOnMessage()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(answerLocator));
            element = wait.Until(r => driver.FindElement(answerLocator));
            element.FindElement(answerLocator).Click();
            return this;
        }

        public YandexHomePage typeLetter(string letter)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(letterLocator));
            driver.FindElement(letterLocator);
            driver.FindElement(letterLocator).Click();
            driver.FindElement(letterLocator).Clear();
            driver.FindElement(letterLocator).SendKeys(letter);
            return this;
        }

        public YandexHomePage clickSendMessenger()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(sendMessengerLocator));
            //driver.FindElements(sendMessengerLocator)[1].Click();
            element = wait.Until(r => driver.FindElement(sendMessengerLocator));
            element.Click();
            return this;
        }

        public void ReadAndReplyMessage(string message)
        {
            openMasseng();
            answerOnMessage();
            typeLetter(message);
            clickSendMessenger();
        }
    }
}
