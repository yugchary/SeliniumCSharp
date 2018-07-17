using System;
using TechTalk.SpecFlow;
using Test123.Pages;

namespace Test123.Tests.SearchCommunity
{
    [Binding]
   
    public class SearchCommunitySteps : Parent
    {
       // [BeforeScenario(Order = 1)]
        

        [When(@"search a community with community name contain '(.*)'")]
        public void GivenSearchACommunityWithCommunityNameContain(string communityName)
        {
            Search search = new Search(driver);
            search.searchComunity(communityName);
        }

        [Then(@"i should see the community'(.*)' in my result")]
        public void ThenIShouldSeeTheCommunityInMyResult(string ExpectedCommunityName)
        {
            Search search = new Search(driver);
            search.CommunityResult(ExpectedCommunityName);
        }
    }
}
