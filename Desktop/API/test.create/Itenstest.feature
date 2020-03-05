Feature: Itenstest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given Quando eu crio uma categoria "<categoria>"
	And a nomeio de "<nome>"
	And defino sua quantidade <quantidade>
	When Eu valido o Item
	Then o resultado nao deve lançar excecao

	Examples: 
	| categoria | nome | quantidade |
	|  casa     | casas |  6         |
	|  carro    | carros|  10        |
	|  alfabeto | letra|  24        |
	|  astro    | lua  |  1         |