using create_a_user.Helper;
using create_a_user.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace create_a_user.SpecFlow
{
    [Binding]
    public class EmployeeSteps
    {
        [Given(@"I have logged in to the TurnUp portal")]
        public void GivenIHaveLoggedInToTheTurnUpPortal()
        {
            ScenarioContext.Current.Pending();
            CommonDrive.driver = new ChromeDriver();
            CommonDrive.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net");

            //Maximum the browser
            //CommonDrive.driver.Manage().Window.Maximize();
            LoginPage LoginObj = new LoginPage();
            LoginObj.PageAction();
        }
        
        [When(@"I add an employee")]
        public void WhenIAddAnEmployee()
        {
            ScenarioContext.Current.Pending();
            EmpolyeePage EmployObj = new EmpolyeePage();
            EmployObj.AddEmployee();
            
        }
        
        [Then(@"The employee should be created successfully")]
        public void ThenTheEmployeeShouldBeCreatedSuccessfully()
        {
            ScenarioContext.Current.Pending();
            EmpolyeePage EmployObj = new EmpolyeePage();
            EmployObj.validation();
            CommonDrive.driver.Quit();
        }
    }
}
