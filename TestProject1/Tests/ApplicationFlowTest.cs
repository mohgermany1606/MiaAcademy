using NUnit.Framework;
using MiAcademyAutomation.Pages;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium;

namespace MiAcademyAutomation.Tests
{
    public class ApplicationFlowTest : BaseTest
    {
        [Test]
        public void TestApplicationFlow()
        {
            
            HomePage homePage = new HomePage(Driver);
            homePage.ClickMiaPrepLink();
            Console.WriteLine("Clicked on Online High School Link");
            MiaPrepPage miaPrepPage = new MiaPrepPage(Driver);
            miaPrepPage.ClickApplyButton();
            Console.WriteLine("Clicked on Apply to Our School");
            ParentInformationPage parentInfoPage = new ParentInformationPage(Driver);
            parentInfoPage.EnterFirstName("Mohini");
            parentInfoPage.EnterLastName("Gupta");
            parentInfoPage.EnterEmail("mohgermany16061991@gmail.com");
            parentInfoPage.SelectCountryCode("+49");
            parentInfoPage.EnterPhoneNumber("15162782538");
            System.Threading.Thread.Sleep(2000);
            parentInfoPage.SelectDropdownOption("Yes");
            parentInfoPage.ClickSecondParentCheckbox();
            parentInfoPage.EnterPreferredStartDate("30-Aug-2024");
            parentInfoPage.ClickNextButton();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("clicked next button");

            // Verify that the Student Information Page is loaded
            StudentInformationPage studentInfoPage = new StudentInformationPage(Driver);;
            System.Threading.Thread.Sleep(1000);      
            NUnit.Framework.Assert.That(studentInfoPage.IsLoaded(), Is.True, "Failed to navigate to the Student Information Page.");     
            Console.WriteLine("Successfully landed on Student Page");
            NUnit.Framework.Assert.Pass("Test completed successfully up to the Student Information Page.");
         
      
        }
    }
}
