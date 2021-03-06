Feature: DeleteProfDetails
	In order to showcase my updated skills to people
	As a seller 
	I would like to delete my existing profile details
	and view the updated details on my profile page

@automate @web
Scenario: I would like to delete Language details in my profile
	Given I have signed in valid credentials
	And I am able to view the home page
	When I click on Profile, click Languages tab and click delete button
	Then I should be able to delete the last entry of Languages