
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Test123.CommunityTest
{
    [Binding]
    public class CreateCommunitySteps:Parent
    {

        [Given(@"Open Browser'(.*)' and navigate to Emblim website")]
        public void GivenOpenBrowserAndNavigateToEmblimWebsite(string Browser)
        {
            Console.WriteLine("Browser name "+Browser);
            invokeBrowser(Browser);
            Console.WriteLine("Opening firefox from wrong place");
            gotoSite(driver);
            
        }


        [When(@"a user signIn '(.*)' with Password '(.*)'")]
        public void GivenAUserSignInWithPassword(string username, string password)
        {
            var home = new Home();
            home.clickSignIn(driver);
            SignIn signin = new SignIn(driver);
            signin.enterValiduserName(driver, username).enterValidpassword(driver, password).submitCredentials(driver);
            //signin.wait(driver);
        }
        
        [When(@"create a new community")]
        public void WhenCreateANewCommunityWithCommunityName()
        {
            createCommunity cs = new createCommunity(driver);
            cs.CreateCommunity();
            
        }
        
        [When(@"fill community fields with community name '(.*)'")]
        public void WhenFillCommunityFieldsAndCreate(string communityname)
        {
           createCommunity cs = new createCommunity(driver);
            cs.EnterCommunityName(communityname);
            cs.SelectGame();
            cs.SelectAge();
            cs.SelectLanguage();
            cs.CommunityIntro();
            cs.SelectFavGame();
            cs.AddTags();
            cs.communitySubmit();

        }

        [Then(@"the community created '(.*)' successfully")]
        public void ThenTheCommunityCreatedSuccessfully(string ExpectedResult)
        {
            Console.WriteLine(ExpectedResult);
        }

        [When(@"create with community name '(.*)' but dont fill required fields game,age and language")]
        public void WhenCreateWithCommunityNameButDontFillRequiredFieldsGameAgeAndLanguage(string communityname)
           {
            createCommunity cs = new createCommunity(driver);
           cs.EnterCommunityName(communityname);
            cs.SelectGame();
            cs.SelectAge();
            cs.SelectLanguage();
            cs.CommunityIntro();
            cs.communitySubmit();
             
        }

        [Then(@"the community'(.*)' not created successfully")]
        public void ThenTheCommunityNotCreatedSuccessfully(string CommunityName)
        {
            createCommunity cs = new createCommunity(driver);
            cs.communitySubmit();

          //  Assert.AreEqual(cs.communitySubmit(), cs.communitySubmit(), "i am in same page");

        }
    }


}

