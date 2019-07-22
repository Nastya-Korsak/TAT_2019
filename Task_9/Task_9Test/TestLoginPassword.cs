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
            driver = new ChromeDriver(@"D:\�������");
            wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
        }

        [Test]
        [TestCase("lvorchik", "1234l4321")]
        public void TestOnTrueLoginAndPassword(string login,string password)
        {
            LoginPageMail loginPageMail = new LoginPageMail(driver);
            loginPageMail.loginAs(login, password);

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(.,'�������� ������')]")));
            var searchElement = driver.FindElement(By.XPath("//span[contains(.,'�������� ������')]"));

            Assert.IsTrue(searchElement.Displayed);
        }

        [Test/*, Timeout(10000)*/]
        [TestCase("", "1234l4321","������� ��� �����")]
        [TestCase("lvorchik", "","������� ������")]
        [TestCase("","","������� ��� ����� � ������")]
        [TestCase("l", "l", "�������� ��� �����")]
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