Feature: SpecFlowFeature2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given a name to item "<nome>"
	And one category for item "<categoria>"
	And gives him a amount <quantidade>
	When I authenticate him
	Then the result shouldn't thow a exception

	Examples: 
	| nome   | categoria | quantidade |
	|  rua   | estrada   |  123456    |
	|  casa  | imovel    |	1         |
	|holanda | pais      |  125       |