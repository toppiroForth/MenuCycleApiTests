Feature: Get Meal Period Tests

Background: Clear all Test related data
	Given the executable query 'select * FROM [SCNET_abokado].[dbo].[meal_period]' is executed against Staging Database
	And the returned 'MealPeriods' are stored in the scenario context
	And all 'MealPeriods' related data are cleared from 'abokado' database

@InitiateWebDriver
Scenario: Get Multiple Meal Periods
	Given I am logged in to StarChef with username 'abokadoadmin' and password '1234'
	Given the user navigates to the 'admin' page
	And the 'Meal Periods' option is selected and its respective tab title 'MEAL PERIODS MANAGEMENT' is displayed
	And the following Meal Periods are added
	| Name                             |
	| ApiTestAutomationMealPeriod_001  |
	| ApiTestAutomationMealPeriod_002  |
	#================
	#Do stuff via API
	#================
	Given The Starchef Menu Service API is accessed
	When the 'teste2e' issues a 'GET' request against Menu Service for 'CEF3DA30-88E8-44C8-9CD7-D64DD37B8C43' on 'MealPeriods' ''
	Then No errors are returned by server
	And the response contains the following Meal Periods
		| Name							  |
		| ApiTestAutomationMealPeriod_001 |
		| ApiTestAutomationMealPeriod_002 |     


@InitiateWebDriver
Scenario: Get a Single Meal Period with a Name filter
	Given I am logged in to StarChef with username 'abokadoadmin' and password '1234'
	Given the user navigates to the 'admin' page
	And the 'Meal Periods' option is selected and its respective tab title 'MEAL PERIODS MANAGEMENT' is displayed
	And the user adds a new meal period with name 'LFC'
	#================
	#Do stuff via API
	#================
	Given The Starchef Menu Service API is accessed
	When the 'teste2e' issues a 'GET' request against Menu Service for 'CEF3DA30-88E8-44C8-9CD7-D64DD37B8C43' on 'MealPeriods' '?$filter=Name eq 'LFC''
	Then No errors are returned by server
	And the response contains the following Meal Periods
		|	Name		|
		|	LFC			|


@InitiateWebDriver
Scenario: Update a Single Meal Period 
	Given I am logged in to StarChef with username 'abokadoadmin' and password '1234'
	Given the user navigates to the 'admin' page
	And the 'Meal Periods' option is selected and its respective tab title 'MEAL PERIODS MANAGEMENT' is displayed
	And the user adds a new meal period with name 'Meal Period for Update'
	And the user edits the description where meal period name is 'Meal Period for Update' to 'Updated Meal Period'
	#================
	#Do stuff via API
	#================
	Given The Starchef Menu Service API is accessed
	When the 'teste2e' issues a 'GET' request against Menu Service for 'CEF3DA30-88E8-44C8-9CD7-D64DD37B8C43' on 'MealPeriods' ''
	Then No errors are returned by server
	And the response contains the following Meal Periods
		|	Name						|
		|	Updated Meal Period			|



#@InitiateWebDriver
#Scenario: Get a Single Meal Period by Id
#	Given I am logged in to StarChef with username 'abokadoadmin' and password '1234'
#	Given the user navigates to the 'admin' page
#	And the 'Meal Periods' option is selected and its respective tab title 'MEAL PERIODS MANAGEMENT' is displayed
#	And the user adds a new meal period with name 'Rarara'
#	#================
#	#Do stuff via API
#	#================
#	Given The Starchef Menu Service API is accessed
#	When the 'teste2e' issues a 'GET' request against Menu Service for 'CEF3DA30-88E8-44C8-9CD7-D64DD37B8C43' on 'MealPeriods' '/28'
#	Then No errors are returned by server
#	And the response contains the Meal Period below
#		|Name		|
#		|Rarara		|





