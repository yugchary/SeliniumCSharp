using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test123
{
    public class BaseFile:Parent
    {

        public void waitxpath(IWebDriver driver, string waitobject)
        {

            WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           // Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(waitobject)));
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(waitobject)));
            Wait.PollingInterval = TimeSpan.FromMilliseconds(100);

        }

        public void waitId(IWebDriver driver, string waitobject)
        {
            try
            {
                WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
                // Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id(waitobject)));
                Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(waitobject)));
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                throw (e);
            }
        }

        public void waitName(IWebDriver driver, string waitobject)
        {

            WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
           // Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name(waitobject)));
           Wait.Until(ExpectedConditions.ElementToBeClickable(By.Name(waitobject)));
        }

        public void waitOn(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(120));
            Console.Write("waiting for element");
        }
        public void waitforElementVisible()
        {
            Thread.Sleep(4000);
        }


        public IWebElement findbyXpath(string xpathvalue)
        {
           // waitxpath(driver, xpathvalue);
           IWebElement xpath= driver.FindElement(By.XPath(xpathvalue));
            Console.WriteLine(xpath);
            return xpath;
            
        }

        public IWebElement findbyName( string namevalue)
        {
           // waitName(driver, namevalue);
            IWebElement objectvalue = driver.FindElement(By.Name(namevalue));
            return objectvalue;
        }

        public void findbyCss(IWebDriver driver, string Cssvalue)
        {
           driver.FindElement(By.CssSelector(Cssvalue)).SendKeys(Keys.Enter);
            
        }

        public IWebElement findbyIdvalue(string Idvalue)
        {
           // waitName(driver, Idvalue);
            IWebElement objectvalue = driver.FindElement(By.Name(Idvalue));
            return objectvalue;
        }



    }
}
