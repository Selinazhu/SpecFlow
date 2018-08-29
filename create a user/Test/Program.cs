using create_a_user.Helper;
using create_a_user.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace create_a_user
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        [SetUp]
        public void LoginAction()
        {
            CommonDrive.driver = new ChromeDriver();
            CommonDrive.driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net");

            //Maximum the browser
            CommonDrive.driver.Manage().Window.Maximize();
            LoginPage LoginObj = new LoginPage();
            LoginObj.PageAction();
        }

        [Test]
        public void addEmployee()
        {
            EmpolyeePage EmployObj = new EmpolyeePage();
            EmployObj.AddEmployee();
            EmployObj.validation();
        }


        [Test]
        public void editEmp()
        {
            EmpolyeePage editObj = new EmpolyeePage();

            editObj.EditAction();
        }

        [Test]
        public void editEmp02()
        {
            EmpolyeePage editEmp02 = new EmpolyeePage();

            editEmp02.edit();
        }

        [Test]
        public void deleEmp()
        {
            EmpolyeePage deleObj = new EmpolyeePage();

            deleObj.DeleteAction();
        }

        [TearDown]
        public void finishAction()
        {
            CommonDrive.driver.Quit();
        }

    }
}
