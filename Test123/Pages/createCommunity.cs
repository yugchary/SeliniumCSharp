using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;
using System;
using System.Configuration;
using System.Threading;

namespace Test123
{
    public class createCommunity
    {

        BaseFile baseclass = new BaseFile();
        IWebDriver driver;
        public createCommunity(IWebDriver driver)
        {
            this.driver = driver;

        }

        public  createCommunity CreateCommunity()
        {
            baseclass.waitforElementVisible();
            baseclass.findbyXpath(ConfigurationManager.AppSettings["createcommunityLink"]).SendKeys(Keys.Enter);
            return this;
        }
         public createCommunity EnterCommunityName(string communityname)
        {
            baseclass.waitforElementVisible();
            baseclass.findbyXpath(ConfigurationManager.AppSettings["CommunityNameObject"]).Click();
            baseclass.findbyXpath(ConfigurationManager.AppSettings["CommunityNameObject"]).SendKeys(communityname);
            return this;
        }

        public createCommunity uploadLogo()
        {
            baseclass.waitforElementVisible();
            baseclass.findbyName(ConfigurationManager.AppSettings["CommunityLogo"]).SendKeys("‪C:\\Users\\senthil\\Desktop\\big-logo.png");
            return this;
        }

        public createCommunity SelectGame()
        {
            baseclass.waitforElementVisible();
            baseclass.findbyXpath((ConfigurationManager.AppSettings["selectGameObject"])).SendKeys("Bobbins" + Keys.Enter);
            return this;
        }
        public createCommunity SelectAge()
        {
            
            baseclass.findbyXpath((ConfigurationManager.AppSettings["SelectAgeObject"])).SendKeys("13+" + Keys.Enter);
            return this;
        }
        public createCommunity SelectLanguage()
        {
            
            baseclass.findbyXpath((ConfigurationManager.AppSettings["SelectLanguageObject"])).SendKeys("Spanish" + Keys.Enter);
            return this;
        }

        public createCommunity CommunityIntro()
        {
            baseclass.waitforElementVisible();
            baseclass.waitId(driver, ConfigurationManager.AppSettings["CommunityIntroductionObject"]);
            baseclass.findbyIdvalue((ConfigurationManager.AppSettings["CommunityIntroductionObject"])).Click();
            baseclass.findbyIdvalue((ConfigurationManager.AppSettings["CommunityIntroductionObject"])).SendKeys("This is for testing");
           
            return this;
        }
        public createCommunity SelectFavGame()
        {

            baseclass.waitforElementVisible();
            baseclass.waitxpath(driver, ConfigurationManager.AppSettings["FavGameObject"]);
            baseclass.findbyXpath((ConfigurationManager.AppSettings["FavGameObject"])).Click();
           
            baseclass.findbyXpath((ConfigurationManager.AppSettings["FavGameObject"])).SendKeys("Sea Dogs"+Keys.Enter+Keys.Enter);
            baseclass.waitforElementVisible();
            baseclass.findbyXpath((ConfigurationManager.AppSettings["FavGameObject"])).SendKeys("Sea Dogs" + Keys.Enter + Keys.Enter);
            return this;
        }

        public createCommunity AddTags()
        {

            baseclass.waitforElementVisible();
            baseclass.findbyXpath((ConfigurationManager.AppSettings["TagObject"])).SendKeys("Test" + Keys.Enter);
            baseclass.waitforElementVisible();
            baseclass.findbyXpath((ConfigurationManager.AppSettings["TagObject"])).SendKeys("Test" + Keys.Enter);
            return this;
        }

        public createCommunity communitySubmit()
        {
            baseclass.waitforElementVisible();
            // baseclass.findbyXpath((ConfigurationManager.AppSettings["CreateCommunitySubmissionObject"])).SendKeys(Keys.Enter);

            return this;
        }



    }
}