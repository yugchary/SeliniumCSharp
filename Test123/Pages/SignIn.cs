using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;


namespace Test123
{
    public class SignIn:BaseFile

    {
        //private IWebElement user
        public new IWebDriver driver;
            public SignIn(IWebDriver driver)
        {
            this.driver = driver;

        }
        public SignIn Switch(IWebDriver driver)
        {
            driver.SwitchTo().Alert();
            return this;
        }

      
        public SignIn enterValiduserName(IWebDriver driver, string userName)
        {
            wait(driver,"displayName");
            
            driver.SwitchTo().ActiveElement();
            Console.WriteLine("Enter user Name");
            findbyXpath(ConfigurationManager.AppSettings["SignInUserNameObject"]).Click();
            findbyXpath(ConfigurationManager.AppSettings["SignInUserNameObject"]).SendKeys(userName);
            return this;
        }
        
        public SignIn enterValidpassword(IWebDriver driver, string password)
        {

            findbyName(ConfigurationManager.AppSettings["SignInPasswordObject"]).Click();
            findbyName(ConfigurationManager.AppSettings["SignInPasswordObject"]).SendKeys(password);
            Console.WriteLine("enter password");
            return this;
          
        }

        public landingPage submitCredentials(IWebDriver driver)
        {
            IWebElement ss = driver.FindElement(By.CssSelector("body > div.modal.membership.ng-scope.top.am-fade > div > div > div.modal-body > form > div:nth-child(4) > button"));
            //Actions act = new Actions(driver);
            //act.MoveToElement(ss).Build().Perform();
            ss.Click();
            //driver.FindElement(By.XPath("/html/body/div[9]/div/div/div[2]/form/div[4]/button")).Submit();
            // driver.FindElement(By.XPath("//button")).SendKeys(Keys.Enter);
            return new landingPage(driver);
        } 
        
    }
}
