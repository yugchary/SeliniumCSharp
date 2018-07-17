using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test123
{
   public class Home:BaseFile
    {
        
               public void clickSignIn(IWebDriver driver)
        {
            //driver.FindElement(By.CssSelector("li.list-inline-item:nth-child(6) > button:nth-child(1)")).SendKeys(Keys.Enter);
            Console.WriteLine("clicking signin");
            findbyCss(driver, "li.list-inline-item:nth-child(6) > button:nth-child(1)");
            var signin = new SignIn(driver);
            //signin.Switch(driver);
        }

    }
}
