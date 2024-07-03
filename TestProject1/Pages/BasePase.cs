using OpenQA.Selenium;

namespace MiAcademyAutomation.Pages
{

    public class BasePage(IWebDriver driver)
    {
        protected IWebDriver Driver = driver;
    }
}