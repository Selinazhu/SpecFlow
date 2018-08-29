Feature: Employee
	As an admin of TurnUp portal
	I need features to be able to add, edit and delete an employee

@mytag
Scenario: Admin should be able to create an employee
	Given I have logged in to the TurnUp portal
	When I add an employee
	Then The employee should be created successfully
	
