
Feature: MenuCycleItemCollections


  Background:    
    Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database

  @MenuCycleItem_Collection
  Scenario: GET-MenuCycleItems collection properites   
     Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and ''     
      And  the 'single' group '95' and '96' request sent to server 
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'PUT' request against a menucycle '/MenuCycles/' and '/items'      
     And user update all the items with day 8 order 3 menuid 94 mealperiod 40 and recipeid 900  	
     Then No errors are returned by server
	 And user should get all menucyleitem id from the response
      And the following MenuCycleitem propertie collection is returned
      | day | order | menuCycleItemType | menuType | menuName   | course   | menuId | mealPeriodId | mealPeriodName | recipeId | recipeName    | cost | costQuantity | costUnitOfMeasure |
      | 8   | 3     | 1                 | 1        | AutoMenu 1 |          | 94     | 40           | MealPeriod 2   |          |               |      |              |                   |
      | 8   | 3     | 0                 | 0        |            | MyCourse | 0      | 40           | MealPeriod 2   | 898      | AutoRecipe001 | 1.78 | -1642486144.0 | myC              |
      | 8   | 3     | 0                 | 0        |            |          | 0      | 40           | MealPeriod 2   | 900      | AutoRecipe003 | 2.82 | 162841936.0  | myC               |
  # Delete a multiple menucycleitems by payload 
    When  user issues 'DELETE' request against a menucycle '/MenuCycles/' and '/items' 
    And user delete multiple menucycleitems 3
    And the request is sent to the server  
   Then No errors are returned by server
   