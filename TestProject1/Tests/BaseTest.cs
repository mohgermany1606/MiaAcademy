using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MiAcademyAutomation.Tests
{
    public class BaseTest
    {
        protected IWebDriver? Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://miacademy.co/#/");
        }

        [TearDown]
        public void Teardown()
        {
            Driver.Quit();
        }
    }
}
