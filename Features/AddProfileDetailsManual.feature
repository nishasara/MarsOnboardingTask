Feature: AddProfileDetailsManual
		Inorder to show my skills to people
	    As seller 
	    I would like to add relevant details in my profile
	    and view the details on my profile page

@manual @web
Scenario: I would like to add two same entries of Languages to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click Languages and add two similar entries
	Then I should not be allowed to add the duplicate entry, showing a pop up "This language is already exist in your language list"
@manual @web
Scenario: I would like to add two same entries of Skills to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click skills and add two similar entries
	Then I should not be allowed to add the duplicate entry, showing a pop up "This skill is already exist in your skill list"
@manual @web
Scenario: I would like to add two same entries of Education to my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click Education and add 2 similar entries
	Then I should not be allowed to add the duplicate entry, showing a pop up "This information is already exist"
@manual @web
Scenario: I would like to view my profile details 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile
	Then I should be able to view the last updated details in my profile

@manual @web
Scenario: I would like to leave the description details blank in my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Description
	When I try to save the description without any details added
	Then It should not allow me to save the description without any details added

@manual @web
Scenario: I would like to cancel the process of entering the Language details in my profile using Cancel Option
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Languages, click Add New and start entering data into fields
	When I click Cancel 
	Then It should cancel the process of data entry and the language fields should not be updated.

@manual @web
Scenario: I would like to add Language details in my profile without choosing Language Level 
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Languages, Click Add New and enter Language
	When I click Add without choosing Language Level
	Then It should not allow me to add the details, showing me a pop up stating 'Please enter language and level'

@manual @web
Scenario: I would like to add Language details in my profile without entering data in any of the fields 
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Languages, Click Add New
	When I click Add without choosing Language Level and Language
	Then It should not allow me to add the details, showing me a pop up stating 'Please enter language and level'

@manual @web
Scenario: I would like to 5 add Language in my profile  
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Languages, add 4 languages
	When I try to add 5th language
	Then The Add New button should disappear not enabling me to add the 5th entry

@manual @web
Scenario: I would like to cancel the process of entering the Skill details in my profile using Cancel Option
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Skills, Click Add New and start entering data into fields
	When I click Cancel 
	Then It should cancel the process of data entry and the skills fields should not be updated.

@manual @web
Scenario: I would like to add Skill details in my profile without choosing Skill Level 
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Skills, Click Add New and enter skill
	When I click Add without choosing Skill Level
	Then It should not allow me to add the details and show me a pop up stating 'Please enter skill and experience level'

@manual @web
Scenario: I would like to add Skill details in my profile without entering data in any of the fields  
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Skills, Click Add New
	When I click Add without choosing Skill Level and Skill
	Then It should not allow me to add the details and show me a pop up stating 'Please enter skill and experience level'

@manual @web
Scenario: I would like to cancel the process of entering the Education details in my profile using Cancel Option
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Education, Click Add New and start entering data into fields
	When I click Cancel 
	Then It should cancel the process of data entry and the Education fields should not be updated.

@manual @web
Scenario: I would like to add Education details in my profile leaving Title field blank
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Education, Click Add New and enter data in all fields except Title
	When I click Add 
	Then It should not allow me to add the details and show me a pop up stating 'Please enter all the fields'

@manual @web
Scenario: I would like to add Education details in my profile leaving College/University Name field blank
	Given I have logged in skill exchange platform with valid credentialsCollege/University Name
	And I click on Profile, click Education, Click Add New and enter data in all fields except College/University Name
	When I click Add 
	Then It should not allow me to add the details and show me a pop up stating 'Please enter all the fields'

@manual @web
Scenario: I would like to add Education details in my profile leaving Country of College/University field blank
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Education, Click Add New and enter data in all fields except Country of College/University
	When I click Add 
	Then It should not allow me to add the details and show me a pop up stating 'Please enter all the fields'

@manual @web
Scenario: I would like to add Education details in my profile leaving Degree field blank
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Education, Click Add New and enter data in all fields except Degree
	When I click Add 
	Then It should not allow me to add the details and show me a pop up stating 'Please enter all the fields'

@manual @web
Scenario: I would like to add Education details in my profile leaving Year of graduation field blank
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Education, Click Add New and enter data in all fields except Year of graduation
	When I click Add 
	Then It should not allow me to add the details and show me a pop up stating 'Please enter all the fields'

@manual @web
Scenario: I would like to cancel the process of entering the Certification details in my profile using Cancel Option
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Certification, Click Add New and start entering data into fields
	When I click Cancel 
	Then It should cancel the process of data entry and the Certification fields should not be updated.

@manual @web
Scenario: I would like to add Certification details in my profile leaving Certificate or Award field blank
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Certification, Click Add New and enter data in all fields except 'Certificate or Award'
	When I click Add 
	Then It should not allow me to add the details and show me a pop up stating 'Please enter Certification Name, Certification From and Certification Year'

@manual @web
Scenario: I would like to add Certification details in my profile leaving Certified From field blank
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Certification, Click Add New and enter data in all fields except 'Certified From'
	When I click Add 
	Then It should not allow me to add the details and show me a pop up stating 'Please enter Certification Name, Certification From and Certification Year'

@manual @web
Scenario: I would like to add Certification details in my profile leaving Year field blank
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Certification, Click Add New and enter data in all fields except 'Year'
	When I click Add 
	Then It should not allow me to add the details and show me a pop up stating 'Please enter Certification Name, Certification From and Certification Year'

@manual @web
Scenario: I would like to add Certification details in my profile without entering data in any of the fields  
	Given I have logged in skill exchange platform with valid credentials
	And I click on Profile, click Certification, Click Add New
	When I click Add without adding data in any of the fields
	Then It should not allow me to add the details and show me a pop up stating 'Please enter Certification Name, Certification From and Certification Year'

@Manual @web
Scenario: I would like to edit the existing description in my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile and click on edit description
	Then I should be able to edit description details and save it

@Manual@web
Scenario: I would like to edit existing skills in my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click Skills and click Edit icon
	Then I should be able to update details of existing skills

@Manual@web
Scenario: I would like to edit existing details of Education in my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click education and click Edit icon
	Then I should be able to update existing details of education

@Manual@web
Scenario: I would like to edit existing details of Certifications in my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click Certifications and click Edit icon
	Then I should be able to update existing certification details

@Manual@web
Scenario: I would like to delete existing skills in my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click Skills and click Delete icon
	Then I should be able to delete details of existing skills

@Manual@web
Scenario: I would like to delete existing details of Education in my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click Education and click Delete icon
	Then I should be able to delete existing details of education

@Manual@web
Scenario: I would like to delete existing details of Certifications in my profile 
	Given I have logged in skill exchange platform with valid credentials
	And I am able to view my homepage
	When I click on Profile, click Certifications and click Delete icon
	Then I should be able to delete existing certification details
