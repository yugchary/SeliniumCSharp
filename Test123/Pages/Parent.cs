using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Test123;

namespace Test123
{
    public class Parent
    {
        public static IWebDriver driver;
        
        public void invokeBrowser(String Browser)
        {
            switch(Browser)
                { 
            case "chrome" :
                    driver = new ChromeDriver("C:\\Users\\senthil\\Documents\\Visual Studio 2015\\Projects\\UnitTestProject12\\Test123\\bin\\Debug");
                    break;

                case "firefox" :
                    driver = new FirefoxDriver();
                    Console.WriteLine("Firefox driver opened");
                    break;

                case "ngdriver" :
                    driver =new NgWebDriver(new FirefoxDriver());
                    break;

                    
            }
          
        }

        public Parent gotoSite(IWebDriver driver)
        {
            var url = ConfigurationManager.AppSettings["Url"];
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public void wait(IWebDriver driver, string waitobject)
        {

            WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
            Wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name(waitobject)));

        }

    }
}
