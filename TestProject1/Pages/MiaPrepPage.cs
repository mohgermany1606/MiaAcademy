using OpenQA.Selenium;

namespace MiAcademyAutomation.Pages
{
    public class MiaPrepPage : BasePage
    {
        private IWebElement ApplyButton => Driver.FindElement(By.XPath("//*[@id=\"kt-layout-id_122039-b8\"]/div/div[1]/div/div[3]/div/a"));

        public MiaPrepPage(IWebDriver driver) : base(driver) { }

        public void ClickApplyButton()
        {
            ApplyButton.Click();
        }
    }
}
