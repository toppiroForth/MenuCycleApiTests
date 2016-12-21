
Feature: UpdateSingelmenucycleitem Menu

  Background: 
    
  @MenuCycle_Create_a_MenuCycleItem 
  Scenario: PUT- Update SingelMenuCycleitem Menu  
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and ''     
	  And  the 'single' group '95' and '96' request sent to server 
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against a menucycle '/MenuCycles/' and '/items'      
      And Item request contains mealpriod 39 and the 'Menu' with id 94  
     Then No errors are returned by server
      And user can get one of the menucycleitemid 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'PUT' request against a menucycle '/MenuCycles/' and '/items'      
	  And user update single item  with day 888 order 3 menuid 0 mealperiod 40 and recipeid 0  	
     Then No errors are returned by server
     And user should get all menucyleitem id from the response
      And the following MenuCycleitem propertie collection is returned
      | day | order | menuCycleItemType | menuType | menuName   | course   | menuId | mealPeriodId | mealPeriodName | recipeId | recipeName    | cost | costQuantity | costUnitOfMeasure |
      | 888 | 3     | 1                 | 1        | AutoMenu 1 |          | 94     | 40           | MealPeriod 2   |          |               |      |              |                   |
      | 9   | 3     | 0                 | 0        |            | MyCourse | 0      | 39           | MealPeriod 1   | 898      | AutoRecipe001 | 1.78 | -1642486144.0 | myC               |
   
  # Delete a multiple menucycleitems by payload 
    When  user issues 'DELETE' request against a menucycle '/MenuCycles/' and '/items' 
    And user delete multiple menucycleitems 2 
    And the request is sent to the server  
   Then No errors are returned by server
   



