Feature: Search
	In order to be able to look for information
	As a internet user
	I want to be in google search

@TestCaseGoogle
Scenario: Open Google
	Given I open google chrome browser
	When I navigate to google
	Then I validate Im on google page

