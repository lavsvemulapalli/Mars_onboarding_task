Feature: Mars
	I want to add profile details.

@mytag
Scenario: Add profile details
	Given I logged into skillswap successfully
	And I enterd  my description and save it
	When I entered all my profile details
	Then I check my profile details are added correctly or not
