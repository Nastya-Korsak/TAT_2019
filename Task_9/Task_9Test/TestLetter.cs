using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Task_9;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;

namespace Task_9Test
{
    class TestLetter
    {
        ChromeDriver driver;
        WebDriverWait wait;
        string letterText;
        By letterIsUnreadLocator = By.XPath("//div[@class='ns-view-container-desc mail-MessagesList js-messages-list']/div[1]//span[@title='Отметить как прочитанное']");
        YandexHomePage yandexHomePage;

        [OneTimeSetUp]
        public void StartBrowserAndSendingLetter()
        {
            driver = new ChromeDriver(@"D:\драйвер");
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));

            //letterText = "kkkk";

            //string mailLogin = "lvorchik";
            //string mailPassword = "1234l4321";

            //LoginPageMail loginPageMail = new LoginPageMail(driver);
            //MailHomePage mailHomePage = loginPageMail.loginAs(mailLogin, mailPassword);
            //mailHomePage.SendMasseng("lvorchik@yandex.by", letterText);
        }

        [OneTimeSetUp]
        public void GoToStartYandexPage()
        {
            LoginPageYandex loginPageYandex = new LoginPageYandex(driver);

            string yandexLogin = "lvorchik";
            string yandexPassword = "1234l4321";
            yandexHomePage = loginPageYandex.loginAs(yandexLogin, yandexPassword);
        }

        [Test]
        public void TestLetterIsUnread()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(letterIsUnreadLocator));
            var searchElement = driver.FindElement(letterIsUnreadLocator);

            Assert.IsTrue(searchElement.Displayed);
        }

        [Test]
        public void TestLetterArriveToYandex()
        {
            yandexHomePage.openMasseng();
        }

        //[Test]
        //public void TestLetterIsTrue()
        //{
        //}
    }
}
