using SkillExchange.Pages;
using SkillExchange.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SkillExchange.StepDefinitions
{
    [Binding]
    public class DeleteProfDetailsSteps: CommonDriver
    {
        [Given(@"I have signed in valid credentials")]
        public void GivenIHaveSignedInValidCredentials()
        {
            LoginPage SignInObj = new LoginPage();
            SignInObj.LoginSteps(driver);
        }
        
        [Given(@"I am able to view the home page")]
        public void GivenIAmAbleToViewTheHomePage()
        {
            LoginPage ValdteObj = new LoginPage();
            ValdteObj.ValidateHomePage(driver);
        }
        
        [When(@"I click on Profile, click Languages tab and click delete button")]
        public void WhenIClickOnProfileClickLanguagesTabAndClickDeleteButton()
        {
            HomePage homePgObj = new HomePage(driver);
            homePgObj.navigateToProfile();
            homePgObj.goToLanguageTab();
        }
        

        [Then(@"I should be able to delete the last entry of Languages")]
        public void ThenIShouldBeAbleToDeleteTheLastEntryOfLanguages()
        {
            HomePage deleteDetailsObj = new HomePage(driver);
            deleteDetailsObj.DeleteLanguages();
        }

    }
}
