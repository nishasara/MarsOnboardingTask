Feature: AddProfileDetails
	Inorder to showcase my skills to people
	As a seller 
	I would like to add my profile details
	and view the same on my profile page

@automate @web
Scenario: I would like to add valid details to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile
	Then I should be able to add details like Availability, Hours, Earn Target in my profile
@automate @web
Scenario: I would like to add description details to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile and click description
	Then I should be able to add description details and save it
@automate @web
Scenario: I would like to add details of languages to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile and click languages
	Then I should be able to add details of languages known and save it
@automate @web
Scenario: I would like to add details of skills to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile and click Skills
	Then I should be able to add details of Skills and save it
@automate @web
Scenario: I would like to add details of education to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile and click education
	Then I should be able to add details of Education and save it
@automate @web
Scenario: I would like to add details of Certifications to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile and click Certifications
	Then I should be able to add details of certification and save it
@automate @web
Scenario: I would like to add two same entries of Certifications to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click Certifications and add two similar details
	Then I should not be allowed to add 2 similar entries showing a pop up







