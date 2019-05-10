using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            LoginPageMail loginPageMail = new LoginPageMail(chromeDriver);
            MailHomePage mailHomePage = loginPageMail.loginAs("lvorchik", "1234l4321");
            mailHomePage.SendMasseng("lvorchik@yandex.by", "hjffkt");

            LoginPageYandex loginPageYandex = new LoginPageYandex(chromeDriver);
            YandexHomePage yandexHomePage = loginPageYandex.loginAs("lvorchik", "1234l4321");
            yandexHomePage.ReadAndReplyMessage("Ольга");

            MailHomePage mailHomePage1 = loginPageMail.loginAs("lvorchik", "1234l4321");
            mailHomePage1.openMasseng();
            string name = mailHomePage1.copyMessege();
            MailChangNamePage mailChangNamePage= mailHomePage1.goToChangNamePaege();
            mailChangNamePage.changeName(name);
            mailChangNamePage.saveChanges();
        }
    }
}
