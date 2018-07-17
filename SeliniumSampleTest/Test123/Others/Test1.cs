using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test123;

namespace Test123
{
    public class Test1:Parent
    {
         Home home=new Home();
        SignIn signin = new SignIn(driver);
        [Test]
        public void Testcase1()
        {
            //invokeBrowser("firefox");
            gotoSite(driver);
            //signin.wait(driver);
            home.clickSignIn(driver);
            //enterValiduserName(driver, "senthil001@mailinator.com");
            // enterValidpassword(driver, "Orange123");
            // submitCredentials(driver);
             signin.enterValiduserName(driver,"senthil001@mailinator.com").enterValidpassword(driver,"Orange123").submitCredentials(driver);
            signin.wait(driver);
            createCommunity cs = new createCommunity(driver);
            cs.CreateCommunity().entercommunityName("test123");
            cs.entergame();
            cs.enterAge();
            cs.EnterLanguage();
            cs.enterIntroduction();
            cs.submitCreateCommunity();
        }
    }
}
