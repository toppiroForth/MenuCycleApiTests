Feature: Menus


Background: 
	Given I am logged in to StarChef with username 'abokadoadmin' and password '123456' 
	Given the user navigates to the 'Menus' page

@Menu1 
Scenario: Create a menu - A La Carte - Exclusive of VAT	
	When user navigate click Create a new menu
	And user enter 'AutomationMenu' as Menu Name
	And user select 'A La Carte' as Menu Type
	And user select 'Menu selling prices are exclusive of VAT' as Include Sales Tax
	And user navigates to  the Menu Items tab
	And user adding new course and enter name 'Test Course' 'Bacon Sandwich'
	And I click on Save in menus toolbar
	And I select Make this ingredient publicly available on the pop up dialog box 'scopeOptionList_2'	