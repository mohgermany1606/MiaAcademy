using OpenQA.Selenium;

namespace MiAcademyAutomation.Pages
{
    public class HomePage : BasePage
    {
        private IWebElement MiaPrepLink => Driver.FindElement(By.XPath("//*[@id=\"contentcontent__ctl3\"]/div/div[2]/div/div/div[2]/span/a"));

        public HomePage(IWebDriver driver) : base(driver) { }

        public void ClickMiaPrepLink()
        {
            MiaPrepLink.Click();
        }
    }
}