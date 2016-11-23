Feature: Get Groups Tests



Scenario: Delete a menu from starChef 
Then the executable query 'select * FROM [SCNET_abokado].[dbo].[menu] where menu_name = 'AutomationApiGroupTest'' is executed against Staging Database
	And the returned 'Groups' are stored in the scenario context	 
	And all 'StarChefGroups' related data are cleared from 'abokado' database 

@InitiateWebDriver
Scenario: Get a single Group with a Name filte
	Given I am logged in to StarChef with username 'abokadoadmin' and password '123456'
	Given the user navigates to the 'admin' page
	And the 'Groups' option is selected and its respective tab title 'Abokado' is displayed
	And creates a new Group with the following details 'and saves'
		| GroupName              | Description                         | TopMostGroup | ParentGroup | DefaultCurrency | DefaultLanguage | SalexTaxName |
		| AutomationApiGroupTest | AutomationApiIntegration Group Test | Abokado      | Abokado     | Pound           | English         | VAT          |
	
	
	

	
	#================
	#Do stuff via API
	#================
	#Given The Starchef Menu Service API is accessed
	#When the 'teste2e' issues a 'GET' request against Menu Service for 'CEF3DA30-88E8-44C8-9CD7-D64DD37B8C43' on 'Groups' '?$filter=Name eq 'AutomationApiGroupTest''
	#Then No errors are returned by server
	#And the response contains the following Groups
	#	| Name                   |
	#	| AutomationApiGroupTest |
	#Then the executable query 'select * FROM [SCNET_abokado].[dbo].[group] where group_name = 'AutomationApiGroupTest'' is executed against Staging Database
	#And the returned 'Groups' are stored in the scenario context	 
	#And all 'StarChefGroups' related data are cleared from 'abokado' database 


#	@InitiateWebDriver
#    Scenario: Update and Get a Group with a Name filter
#	Given I am logged in to StarChef with username 'abokadoadmin' and password '1234'
#	Given the user navigates to the 'admin' page
#	And the 'Groups' option is selected and its respective tab title 'Abokado' is displayed
#	And creates a new Group with the following details 'and saves'
#		| GroupName                         | Description                         | TopMostGroup | ParentGroup | DefaultCurrency | DefaultLanguage | SalexTaxName |
#		| AutomationApiGroupTest for Update | AutomationApiIntegration Group Test | Abokado      | Abokado     | Pound           | English         | VAT          |
#	And the user navigates to the 'admin' page
#	And the 'Groups' option is selected and its respective tab title 'Abokado' is displayed
#	And the user edits the 'AutomationApiGroupTest for Update' group with the following details 'and saves'
#		| GroupName                     | Description                             |
#		| UpdatedAutomationApiGroupTest | AutomationApiIntegration Group  Updated |
#	#================
#	#Do stuff via API
#	#================
#	Given The Starchef Menu Service API is accessed
#	When the 'teste2e' issues a 'GET' request against Menu Service for 'CEF3DA30-88E8-44C8-9CD7-D64DD37B8C43' on 'Groups' '?$filter=Name eq 'UpdatedAutomationApiGroupTest''
#	Then No errors are returned by server
#	And the response contains the following Groups
#		| Name                          |
#		| UpdatedAutomationApiGroupTest |
#	Then the executable query 'select * FROM [SCNET_abokado].[dbo].[group] where group_name = 'UpdatedAutomationApiGroupTest'' is executed against Staging Database
#	And the returned 'Groups' are stored in the scenario context	 
#	And all 'StarChefGroups' related data are cleared from 'abokado' database 
#
#	@InitiateWebDriver
#Scenario: Get Multiple Groups
#	Given I am logged in to StarChef with username 'abokadoadmin' and password '1234'
#	Given the user navigates to the 'admin' page
#	And the 'Groups' option is selected and its respective tab title 'Abokado' is displayed
#	And creates a new Group with the following details 'and saves'
#		| GroupName                  | Description                         | TopMostGroup | ParentGroup | DefaultCurrency | DefaultLanguage | SalexTaxName |
#		| AutomationApiGroupTest_001 | AutomationApiIntegration Group Test | Abokado      | Abokado     | Pound           | English         | VAT          |
#		| AutomationApiGroupTest_002 | AutomationApiIntegration Group Test | Abokado      | Abokado     | Dollar          | English         | VAT          |
#	#================
#	#Do stuff via API
#	#================
#	Given The Starchef Menu Service API is accessed
#	When the 'teste2e' issues a 'GET' request against Menu Service for 'CEF3DA30-88E8-44C8-9CD7-D64DD37B8C43' on 'Groups' ''
#	Then No errors are returned by server
#	And the response contains the following Groups
#		| Name                       |
#		| AutomationApiGroupTest_001 |
#		| AutomationApiGroupTest_002 |
#	Then the executable query 'select * FROM [SCNET_abokado].[dbo].[group] where group_name like 'AutomationApiGroupTest_%'' is executed against Staging Database
#	And the returned 'Groups' are stored in the scenario context	 
#	And all 'StarChefGroups' related data are cleared from 'abokado' database 
#
#
#	#The step for editing a Group is not working, because of the locating the tree items in the TreeView in Groups
#	@InitiateWebDriver
#	Scenario: TestingEditingGroup
#	Given I am logged in to StarChef with username 'abokadoadmin' and password '1234'
#	Given the user navigates to the 'admin' page
#	And the 'Groups' option is selected and its respective tab title 'Abokado' is displayed
#	And the user edits the 'Nova Grupa' group with the following details 'and saves'
#		| GroupName                     | Description                             |
#		| UpdatedAutomationApiGroupTest | AutomationApiIntegration Group  Updated |