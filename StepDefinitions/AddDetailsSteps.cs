using SkillExchange.Pages;
using SkillExchange.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SkillExchange.StepDefinitions
{
    [Binding]
    public class ProfileDetailsSteps :CommonDriver
    {
        [Given(@"I have logged in skill exchange platform with valid credentials")]
        public void GivenIHaveLoggedInSkillExchangePlatformWithValidCredentials()
        {
            LoginPage lgnObj = new LoginPage();
            lgnObj.LoginSteps(driver);
        }
        
        [Given(@"I am able to view my homepage")]
        public void GivenIAmAbleToViewMyHomepage()
        {
            LoginPage  ValdteObj = new LoginPage();
            ValdteObj.ValidateHomePage(driver);
        }
        
        [When(@"I click on Profile")]
        public void WhenIClickOnProfile()
        {
            HomePage homePgObj = new HomePage(driver);
            homePgObj.navigateToProfile();
            
        }
        
        [Then(@"I should be able to add details like Availability, Hours, Earn Target in my profile")]
        public void ThenIShouldBeAbleToAddDetailsLikeAvailabilityHoursEarnTargetInMyProfile()
        {
            HomePage addDetailsObj = new HomePage(driver);
            addDetailsObj.addDetails();
        }

        [When(@"I click on Profile and click description")]
        public void WhenIClickOnProfileAndClickDescription()
        {
            HomePage addDescObj = new HomePage(driver);
            addDescObj.navigateToProfile();
            
        }

        [Then(@"I should be able to add description details and save it")]
        public void ThenIShouldBeAbleToAddDescriptionDetailsAndSaveIt()
        {
            HomePage addDescObj = new HomePage(driver);
            addDescObj.AddDescription();
        }

        [When(@"I click on Profile and click languages")]
        public void WhenIClickOnProfileAndClickLanguages()
        {
            HomePage langObj = new HomePage(driver);
            langObj.goToLanguageTab();
        }

        [Then(@"I should be able to add details of languages known and save it")]
        public void ThenIShouldBeAbleToAddDetailsOfLanguagesKnownAndSaveIt()
        {
            HomePage addLangObj = new HomePage(driver);
            addLangObj.addLanguages();
        }

        [When(@"I click on Profile and click Skills")]
        public void WhenIClickOnProfileAndClickSkills()
        {
            HomePage skillsObj = new HomePage(driver);
            skillsObj.goToSkillsTab();
        }

        [Then(@"I should be able to add details of Skills and save it")]
        public void ThenIShouldBeAbleToAddDetailsOfSkillsAndSaveIt()
        {
            HomePage addSkillsObj = new HomePage(driver);
            addSkillsObj.addSkills();
        }

        [When(@"I click on Profile and click education")]
        public void WhenIClickOnProfileAndClickEducation()
        {
            HomePage educationObj = new HomePage(driver);
            educationObj.goToEducationTab();
        }

        [Then(@"I should be able to add details of Education and save it")]
        public void ThenIShouldBeAbleToAddDetailsOfEducationAndSaveIt()
        {
            HomePage addEducationObj = new HomePage(driver);
            addEducationObj.addEducation();
        }

        [When(@"I click on Profile and click Certifications")]
        public void WhenIClickOnProfileAndClickCertifications()
        {
            HomePage certificationObj = new HomePage(driver);
            certificationObj.goToCertificationTab();
        }

        [Then(@"I should be able to add details of certification and save it")]
        public void ThenIShouldBeAbleToAddDetailsOfCertificationAndSaveIt()
        {
            HomePage addCertificationObj = new HomePage(driver);
            addCertificationObj.addCertifications();
        }
        [When(@"I click on Profile, click Certifications and add two similar details")]
        public void WhenIClickOnProfileClickCertificationsAndAddTwoSimilarDetails()
        {
            HomePage certSimilarEntryObj = new HomePage(driver);
            certSimilarEntryObj.goToCertificationTab();
        }
        [Then(@"I should not be allowed to add (.*) similar entries showing a pop up")]
        public void ThenIShouldNotBeAllowedToAddSimilarEntriesShowingAPopUp()
        {
            HomePage similarEntryObj = new HomePage(driver);
            similarEntryObj.checkDuplicateEntries();
        }


    }
}
