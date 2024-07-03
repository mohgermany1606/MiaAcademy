using OpenQA.Selenium;

namespace MiAcademyAutomation.Pages
{
    public class StudentInformationPage : BasePage
    {
        private IWebElement StudentInfoHeading => Driver.FindElement(By.XPath("//*[@id=\"Section3-li\"]/h2/div/b"));

        public StudentInformationPage(IWebDriver driver) : base(driver) { }

        public bool IsLoaded()
        {
            return StudentInfoHeading.Displayed;
        }
    }
}
