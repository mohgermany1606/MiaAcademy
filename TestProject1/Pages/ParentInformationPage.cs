using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MiAcademyAutomation.Pages
{
    public class ParentInformationPage : BasePage
    {
        private IWebElement FirstNameField => Driver.FindElement(By.XPath("//*[@id=\"Name-li\"]/div[2]/div/span[1]/input"));
        private IWebElement LastNameField => Driver.FindElement(By.XPath("//*[@id=\"Name-li\"]/div[2]/div/span[2]/input"));
        private IWebElement EmailField => Driver.FindElement(By.Name("Email"));
        private IWebElement PhoneNumberField => Driver.FindElement(By.XPath("//*[@id='PhoneNumber']"));
        private IWebElement CountryCodeDropdown => Driver.FindElement(By.XPath("//*[@id='PhoneNumber-li']/div[2]/div/div/div/div/div[3]"));
        private IWebElement NextButton => Driver.FindElement(By.XPath("//*[@id=\"formAccess\"]/div[1]/div/div/button"));


private IWebElement SecondParentCheckbox => Driver.FindElement(By.XPath("//*[@id='Checkbox-arialabel']/span"));
        private IWebElement PreferredStartDateField => Driver.FindElement(By.XPath("//*[@id='Date-date']"));
        public ParentInformationPage(IWebDriver driver) : base(driver) { }

        public void EnterFirstName(string firstName)
        {
            FirstNameField.SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            LastNameField.SendKeys(lastName);
        }

        public void EnterEmail(string email)
        {
            EmailField.SendKeys(email);
        }

        public void EnterPhoneNumber(string phoneNumber)
        {
            PhoneNumberField.SendKeys(phoneNumber);
        }

        public void SelectCountryCode(string countryCode)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            CountryCodeDropdown.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//span[text()='{countryCode}']")));
            IWebElement countryOption = Driver.FindElement(By.XPath($"//span[text()='{countryCode}']"));
            countryOption.Click();
        }

        public void SelectDropdownOption(string optionText)
        {
            IWebElement dropdown = Driver.FindElement(By.XPath("//*[@id='Dropdown-li']/div[2]/div[1]/span/span[1]/span/span[2]"));
            dropdown.Click();

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//li[text()='{optionText}']")));

            IWebElement option = Driver.FindElement(By.XPath($"//li[text()='{optionText}']"));
            option.Click();
        }

        public void ClickNextButton()
        {
            //IWebElement nextButton = Driver.FindElement(By.XPath("//*[@id='formAccess']/div[1]/div/div/button"));

            // Click the Next button
            NextButton.Click();
        }

        public void ClickSecondParentCheckbox()
        {
            if (!SecondParentCheckbox.Selected)
            {
                SecondParentCheckbox.Click();
            }
        }

        public void EnterPreferredStartDate(string date)
        {
            PreferredStartDateField.SendKeys(date);
        }
        public void WaitForPageToLoad()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"Name-li\"]/div[2]/div/span[1]/input")));
        }

        public bool IsStudentInformationPageLoaded()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"Section3-li\"]/h2/div/b"))) != null;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
