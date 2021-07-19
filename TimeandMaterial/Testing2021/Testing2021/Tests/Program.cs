using Automation_Testing2021Code.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace Testing2021
{
    [TestFixture]
    class Program : Utilities.Commondriver

    {


        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver("C:/Supriya/TimeandMaterial/Testing2021/Testing2021/");
            Loginpage loginobj = new Automation_Testing2021Code.Pages.Loginpage();
            loginobj.LoginActions(driver);
            Automation_Testing2021Code.Pages.Homepage homepageObj = new Automation_Testing2021Code.Pages.Homepage();
            homepageObj.gotoTMpage(driver);

        }
       [Test]
        public void CreateTMTest()
        {

            //object for TM page

            Automation_Testing2021Code.Pages.TMpage tmPageObj = new Automation_Testing2021Code.Pages.TMpage();

            tmPageObj.CreateTM(driver);
        }


        
        
        [Test]
        public void EditTMTest()
        {

            //object for TM page

            Automation_Testing2021Code.Pages.TMpage tmobj = new Automation_Testing2021Code.Pages.TMpage();
            tmobj.Edit(driver);
        }

        [Test]
        public void DeleteTMTest()
        {

            //object for TM page

            Automation_Testing2021Code.Pages.TMpage tmobj = new Automation_Testing2021Code.Pages.TMpage();
            tmobj.Delete(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {


        }
    
}
}
