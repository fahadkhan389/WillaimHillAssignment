Feature: AddHorseBetting
	As online Punter
	I should be able to add horse bet to Bet slip 
	after adding stake	

	Background: 
	Given i have opened a FireFox browser
	And i am on williamHill betting website
	And I clicked Racing section
	And I selected Next to Jump Section
@mybetting
Scenario: Add horse racing bet
	Given i selected fifth race from the list
	And i selected first competitor for winning and enter stake "10.5"
	When I clicked on Add to Bet Slip
	And I clicked Bet Slip
	Then Bet should be added in BetSlip section of stake "$ 10.5"
