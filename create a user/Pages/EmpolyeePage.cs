using create_a_user.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace create_a_user.Pages
{
    class EmpolyeePage
    {
        public EmpolyeePage()
        {
            PageFactory.InitElements(CommonDrive.driver, this);
        }

        //codes of the add actions
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/ul/li[5]/a")]
        private IWebElement Administrator { set; get; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a")]
        private IWebElement Employee { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/p/a")]
        private IWebElement Create { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Name']")]
        private IWebElement Name { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Username']")]
        private IWebElement userName { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ContactDisplay']")]
        private IWebElement Contact { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement Password { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='RetypePassword']")]
        private IWebElement RetypePassword { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SaveButton']")]
        private IWebElement Save { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/a")]
        private IWebElement BackToList { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='usersGrid']/div[4]/a[4]/span")]
        private IWebElement lastPage { set; get; }


        // codes of the edit actions
        [FindsBy(How = How.XPath, Using = "//*[@id='usersGrid']/div[3]/table/tbody/tr[7]/td[1]")]
        private IWebElement CreatedName { set; get; }

        [FindsBy(How = How.XPath,Using = "//*[@id='usersGrid']/div[3]/table/tbody/tr[7]/td[3]/a[1]")]
        private IWebElement EditButtton { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ContactDisplay']")]
        private IWebElement ContactPath { set; get; }

        [FindsBy(How = How.XPath, Using = "//*[@id='usersGrid']/div[3]/table/tbody/tr[7]/td[3]/a[2]")]
        private IWebElement DeleteButton { set; get; }

        [FindsBy(How = How.Name, Using ="Cancel")]
        private IWebElement PopInfor { set; get; }

        // codes of the delete actions

        public void AddEmployee()
        {

            //click the create button

            Administrator.Click();

            //click the employee button
            Employee.Click();

            //click the Create button
            Create.Click();

            //create the Name
            String NameT = "testers";
            Thread.Sleep(2000);

            Name.SendKeys("testers");

            //create the username
            userName.SendKeys("testerss");

            //create the contact

            Contact.SendKeys("1234");

            //create the password

            Password.SendKeys("Sa1234567");

            //retypepassword
            RetypePassword.SendKeys("Sa1234567");

            //click the Save button

            Save.Click();

            //back to the previous page

            BackToList.Click();

            Thread.Sleep(2000);


            //validation
            //if (CommonDrive.driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[1]/td[1]")).Text == NameT)
            //{
            //    Console.WriteLine("the new user is located in the first page");
            //}
            //else
            //{
            //    Thread.Sleep(2000);
            //    lastPage.Click();

            //    if (CommonDrive.driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[2]/td[1]")).Text == NameT)
            //    {
            //        Console.WriteLine("the new user is created succefully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("the new user is not existing, the test faild");
            //    }


            //}
            //var testpage = CommonDrive.driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[1]/td[1]")).Text;
            //Assert.AreEqual(NameT, testpage);
        }
        
        //validation the created employee is already in the list
        public void validation()
        {
            // Thread.Sleep(3000);
            //wait expected element is visiable on the page
            //WebDriverWait wait = new WebDriverWait(CommonDrive.driver, new TimeSpan(0, 0, 3));//var wait = new WebDriverWait((CommonDrive.driver,Timrspan.FromSeconds(10)));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='usersGrid']/div[4]/a[3]/span")));

            Create.WaitElement(TimeSpan.FromSeconds(10));


            //
            // CommonDrive.driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(3));
            while (true)//true means that keep going to the next page until the value is matched
            {
                var i = 1;
                while (i <= 10)
                {
                    var name = CommonDrive.driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr["+i+"]/td[1]")).Text;
                    if (name == "testers")
                    {
                        Console.WriteLine("test passed");
                        return;// adding return means in this case, when the name == testers, it will out of the loop; otherwise it will keep looping this condition
                    }
                    i++;
                }
                var btnNext = CommonDrive.driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[3]/span"));
                btnNext.Click();

            }
        }

        public void EditAction()
        {
            //click the create button

            Administrator.Click();

            //click the employee button
            Employee.Click();

            Thread.Sleep(3000);
            //click the lastPage button
            lastPage.Click();

            //click the edit button
            EditButtton.Click();

            //change the new contact information
            ContactPath.SendKeys("123456");

            //click the Save button
            Save.Click();

            //click the Back to list button
            BackToList.Click();
        }

        public void edit()
        {
            //click the create button

            Administrator.Click();

            //click the employee button
            Employee.Click();

            Thread.Sleep(3000);
            //click the lastPage button
            lastPage.Click();

            //click the edit button
            EditButtton.Click();

            userName.Click();
            userName.Clear();
            userName.SendKeys("Testers");
            //click the Save button
            Save.Click();

            //click the Back to list button
            BackToList.Click();

        }

        public void DeleteAction()
        {
            //click the create button

            Administrator.Click();

            //click the employee button
            Employee.Click();

            Thread.Sleep(3000);
            //click the lastPage button
            lastPage.Click();

            //click the delete button
            DeleteButton.Click();

            Thread.Sleep(3000);

            //click the POPup information
            CommonDrive.driver.SwitchTo().Alert().Dismiss();
        }
    }
}
