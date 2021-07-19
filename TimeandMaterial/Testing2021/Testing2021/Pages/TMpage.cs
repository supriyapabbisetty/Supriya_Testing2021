using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automation_Testing2021Code.Pages
{
    class TMpage
    {
        //test-create new TM
        public void CreateTM(IWebDriver driver)
        {
            //click on create New button

            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            Thread.Sleep(2000);

            //select on Time from drop down box
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();

            //select code

            driver.FindElement(By.Id("Code")).SendKeys("projectjune");

            //enter text in description box
            driver.FindElement(By.Id("Description")).SendKeys("projectjune");

            //enter text in peice per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("1234");

            //click on save botton
            driver.FindElement(By.Id("SaveButton"));

            //saved data should be dispalyed in the last page
            driver.FindElement(By.Id("SaveButton")).Click();

            Thread.Sleep(2000);
            //after save  go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            Thread.Sleep(2000);

            //to get to the last page in code
            IWebElement lastbuttonCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));



            Console.WriteLine(lastbuttonCode.Text);
            if (lastbuttonCode.Text == "projectjune")
            {

                Console.WriteLine("time record is successful, test passed");
            }
            else
            {
                Console.WriteLine("time record is unsuccessful, test failed");

            }

        }
        //test-edit  TM
        public void Edit(IWebDriver driver)
        {
            //click on edit button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]")).Click();

            //*[@id="tmsGrid"]/div[3]/table/tbody/tr[10]/td[5]/a[1]


            IWebElement codefield = driver.FindElement(By.Id("Code"));
            codefield.Clear();
            //change code
            codefield.SendKeys("update pj");


            //change descrition
            IWebElement descfield = driver.FindElement(By.Id("Description"));
            descfield.Clear();
            descfield.SendKeys("update pj");

            //chamge price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("12");
            //priceper.Clear();
            // priceper.SendKeys("12345");

            //click save 
            driver.FindElement(By.Id("SaveButton"));

            //saved data should be dispalyed in the last page
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(2000);


            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            Thread.Sleep(2000);

            //to get to the last page in code
            IWebElement updatelastbuttonCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //compare the data saved correctly for Test pass or fail

            Console.WriteLine(updatelastbuttonCode.Text);
            if (updatelastbuttonCode.Text == "update pj")
            {

                Console.WriteLine("update time record is successful, test passed");
            }
            else
            {
                Console.WriteLine("update time record is unsuccessful, test failed");

            }

        }

        //test-delete TM
        public void Delete(IWebDriver driver)
        {
            //click on Delete button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Alert().Accept();

            //a pop window should display with are you sure to delete and click on it
            //driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();


            //record should be deleted from the last page

        }
    }
}
