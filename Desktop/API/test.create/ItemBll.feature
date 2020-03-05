Feature: ItemBll
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Validacao do item
	Given Que o nome do item seja "<nome>"
	And A quantidade  seja <quantidade>
	When Eu valido o item
	Then o resultado deve não deve dar erro

	Examples:
		| nome   | quantidade |
		| xablau | 5          |
		| Texas  | 25000      |
		| ☺asd§☻ | 65         |
		| sd     | 5          |
		| d      | 5          |