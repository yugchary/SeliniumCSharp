//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test123.Pages
{
    class Search
    {
        IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//*[@id='searchBox']")]
        private IWebElement searchField;

        [FindsBy(How=How.XPath,Using = "//*[@id='community - search']/button")]
        private IWebElement searchButton;

        [FindsBy(How=How.XPath,Using = "//a[text()='Test']")]
        private IWebElement ValidatecommunityTile;

        

        public Search(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public Search searchComunity(string communityName)
        {
            var basefile = new BaseFile();

            Thread.Sleep(5000);
            basefile.findbyXpath("//*[@id='searchBox']").SendKeys(communityName+Keys.Enter);
           // Thread.Sleep(3000);
           // Thread.Sleep(3000);
           // searchButton.SendKeys(Keys.Enter);
           // searchButton.Click();
            return this;
        }
        public Search CommunityResult(string ExpectedCommunityName)
        {
            Thread.Sleep(6000);
            string actualresult = ValidatecommunityTile.GetAttribute("text");
            //Assert.AreEqual(ExpectedCommunityName, actualresult);
            return this;
        }

    }
}
