using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automation_Testing2021Code.Pages
{
    class Loginpage
    {
        //function that allows the users to login to TP portal
        public void LoginActions(IWebDriver driver)
        {
            // open chrome browser
            //IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"C:\Supriya\TimeandMaterial\Testing2021\Testing2021\");
            driver.Manage().Window.Maximize();
            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            Thread.Sleep(2000);

            // identify username textbox and enter valid username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
            // identify password textbox and enter valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            // indentify login action button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

        }
    }
}
