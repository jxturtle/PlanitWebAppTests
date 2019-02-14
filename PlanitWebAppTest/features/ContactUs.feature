Feature: Contact Us
	In order to make a general enquiry
	As a job seeker
	I want to be able to make contact Planit


Background: 
Given I am on Planit's 'Contact Us' page
@contactUs
Scenario Outline: No job title submitted
	Given I have entered a first name of <firstName>
	And I have entered a last name of <lastName>
	But no job title has been specified
	When I submit my enquiry
	Then an error prompt for blank job title appears 

	Examples:
	| firstName | lastName |
	| Dogalisk  | eeeee    |
	| yyy       | eeeerrr  |     
	| test3     | yeh      |


@contactUs
Scenario Outline: No email address submitted
	Given I have entered a first name of <firstName>
	And I have entered a last name of <lastName>
	But there has been no specified email address
	When I submit my enquiry
	Then an error prompt for blank email address appears

	Examples:
	| firstName | lastName |
	| Dogalisk  | eeeee    |
	| yyy       | eeee     |
	| test3     | yeh      |