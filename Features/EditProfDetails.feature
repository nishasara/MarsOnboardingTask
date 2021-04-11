Feature: EditProfDetails
	In order to showcase my updated skills to people
	As a seller 
	I would like to edit my existing profile details
	and view the updated details on my profile page


@automate @web
Scenario: I would like to edit Language details in my profile 
	Given I have logged in with valid credentials
	And I am able to view my home page
	When I click on my Profile, go to Languages tab and click edit button
	Then I should be able to update details of last row of existing languages