## This is automated test framework for MiaAcademy to go to Parent Information Page , fill the details and navigate to Student Information Page
## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio Code](https://visualstudio.microsoft.com/downloads/)
- [Chrome Browser](https://www.google.com/chrome/)
- [ChromeDriver](https://sites.google.com/a/chromium.org/chromedriver/)
- This project is based on POM model and separate class is created for each page . It has majorly two folders(Pages & Tests) in which page class and respective test class are present.
ApplicationFlowTest.cs file contains the code to run the project

## Following drivers need to be installed:

- dotnet add package Selenium.WebDriver --version 4.0.0**
- dotnet add package Selenium.WebDriver.ChromeDriver --version 96.0.4664.4500**
- dotnet add package NUnit --version 3.13.2**
- dotnet add package NUnit3TestAdapter --version 4.0.0
- dotnet add package Microsoft.NET.Test.Sdk --version 16.11.0
- dotnet add package Selenium.Support --version 4.0.0

## Run the test
**Running Mechanism : To run the build open the terminal and use dotnet test command**
## Additional Notes
**Wait Mechanism: The framework uses explicit waits to handle dynamic web elements.**
**Assertions: Assertions are used to validate the success of navigation and form submissions**
**Logging: Console logging is used for debugging and understanding the flow of test execution**
