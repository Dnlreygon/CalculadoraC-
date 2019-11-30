Feature: Calculadora
	In order to test the basic math functions
	As a calculator user
	I want to ensure the basic functions works

@TC01
Scenario: Sum
	Given I set 50 as first number on calculator
	And I set 20 into the calculator
	When Execute sum operation
	Then The result should be 70

	@TC02
Scenario: Substraction
	Given I set 5 as first number on calculator
	And I set 2 into the calculator
	When Execute substraction operation
	Then The result should be 3
	@TC02

Scenario: Multiplication
	Given I set 5 as first number on calculator
	And I set 2 into the calculator
	When Execute multiplicacion operation
	Then The result should be 10

	@TC02
Scenario: Division
	Given I set 10 as first number on calculator
	And I set 2 into the calculator
	When Execute division operation
	Then The result should be 5