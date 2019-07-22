using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Task_9;

namespace Tests
{
    public class TestsLoginPassword
    {
        ChromeDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver(@"D:\драйвер");
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
        }

        [Test]
        [TestCase("lvorchik", "1234l4321")]
        public void TestOnTrueLoginAndPassword(string login,string password)
        {
            LoginPageMail loginPageMail = new LoginPageMail(driver);
            loginPageMail.loginAs(login, password);

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,'Написать письмо')]")));
            var searchElement = driver.FindElement(By.XPath("//span[contains(.,'Написать письмо')]"));

            Assert.IsTrue(searchElement.Displayed);
        }

        [Test/*, Timeout(10000)*/]
        [TestCase("", "1234l4321","Введите имя ящика")]
        [TestCase("lvorchik", "","Введите пароль")]
        [TestCase("","","Введите имя ящика и пароль")]
        [TestCase("l", "l", "Неверное имя ящика")]
        public void TestOnFalseLoginAndPassword(string login, string password, string errorText)
        {
            By erroreLocator = By.XPath("//div[@id='mailbox:error']");

            LoginPageMail loginPageMail = new LoginPageMail(driver);
            loginPageMail.loginAs(login, password);

            wait.Until(ExpectedConditions.ElementToBeClickable(erroreLocator));
            var searchElement = driver.FindElement(erroreLocator);

            Assert.IsTrue(errorText == searchElement.Text);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}