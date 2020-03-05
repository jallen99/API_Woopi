Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered <value1> into the calculator
	And I have entered other <value2> into the calculator
	When I press add
	Then the result should be <result> on the screen

	Examples:
		| value1 | value2 | result |
		| 1      | 1      | 2      |
		| 10     | 10     | 20     |