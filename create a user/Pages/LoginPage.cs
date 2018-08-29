using create_a_user.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_a_user.Pages
{
    class LoginPage

    {
        public LoginPage()
        {
            PageFactory.InitElements(CommonDrive.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
        private IWebElement username { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement password { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='loginForm']/form/div[3]/input[1]")]
        private IWebElement login { set; get; }


        public void PageAction()
        {
          

            //inter the username

            username.SendKeys("hari");

            //inter the password

            password.SendKeys("123123");

            //click the Login button

            login.Click();

        }
    }
}
