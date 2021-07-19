using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Automation_Testing2021Code.Pages
{
    class Homepage
    {
      //function to navigate TM pagr
      public void gotoTMpage(IWebDriver driver)
        {
            

            //click on Administartion 
            driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a")).Click();
            Thread.Sleep(2000);
            //select Time and Material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
            Thread.Sleep(2000);

        }
    }
}
