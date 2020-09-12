Feature: Select
	Select the menu option and do some operation.

@test1
Scenario: perform subtraction of 2 dates
	Given I Launch the Application
	
	And I click the submit button
	
	And I click the submit button
	Then I should see the result 

@test2
Scenario: Changing the locale.
    Given I Given I Launch the Application
	When I select the german language
	Then I should see the output