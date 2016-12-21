
@RootSource
Feature: Root Resource Content

@Root_Resource
  Scenario: Root Resource 
      Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '' and ''     
	 When the request is sent to the server
     Then No errors are returned by server
	 And the following root properites are returned
     | userID              | organisationID    |
     | AutomationTestUser1 | organisationName  |
	 And the following root entities are returned
	  | Class           | rel                   | href                                             |
	  | Menu Cycles     | /rels/menucycles      | http://ci-menuservice.fourth.com/MenuCycles      |
	  | Meal Periods    | /rels/mealperiods     | http://ci-menuservice.fourth.com/MealPeriods     |
	  | Menus           | /rels/menus           | http://ci-menuservice.fourth.com/Menus           |
	  | Recipes         | /rels/recipes         | http://ci-menuservice.fourth.com/Recipes         |
	  | Locations       | /rels/locations       | http://ci-menuservice.fourth.com/Locations       |
	  | Groups          | /rels/groups          | http://ci-menuservice.fourth.com/Groups          |
	  | Tariffs         | /rels/tariffs         | http://ci-menuservice.fourth.com/Tariffs         |
	  | SellPriceModels | /rels/sellpricemodels | http://ci-menuservice.fourth.com/SellPriceModels | 
	  And the follwing links are returned 
      | href                                 |                    
      | http://ci-menuservice.fourth.com/    | 
      And the follwing links properties are returned 
      | method | title              | type                        |
      | GET    | Root               | application/vnd.siren+json; |
	   