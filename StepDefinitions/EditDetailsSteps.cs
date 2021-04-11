using SkillExchange.Pages;
using SkillExchange.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SkillExchange.StepDefinitions
{
    [Binding]
    public class EditProfDetailsSteps:CommonDriver
    {
        [Given(@"I have logged in with valid credentials")]
        public void GivenIHaveLoggedInWithValidCredentials()
        {
            LoginPage SignObj = new LoginPage();
            SignObj.LoginSteps(driver);
        }
        
        [Given(@"I am able to view my home page")]
        public void GivenIAmAbleToViewMyHomePage()
        {
            LoginPage ValdteObj = new LoginPage();
            ValdteObj.ValidateHomePage(driver);
        }
        
        [When(@"I click on my Profile, go to Languages tab and click edit button")]
        public void WhenIClickOnMyProfileGoToLanguagesTabAndClickEditButton()
        {
            HomePage homePgObj = new HomePage(driver);
            homePgObj.navigateToProfile();
            homePgObj.goToLanguageTab();
        }
        
        [Then(@"I should be able to update details of last row of existing languages")]
        public void ThenIShouldBeAbleToUpdateDetailsOfLastRowOfExistingLanguages()
        {
            HomePage editDetailsObj = new HomePage(driver);
            editDetailsObj.editLanguages();
        }
    }
}
