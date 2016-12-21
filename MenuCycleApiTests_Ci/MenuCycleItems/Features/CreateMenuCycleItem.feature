Feature: CreateMenuCycleItem

  Background: 
    Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database
  
  @MenuCycle_Create_a_MenuCycleItem 
  Scenario: POST- MenuCycleItem with Manu 
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
     When user issues 'DELETE' request against a menucycleitem '/MenuCycles/' and '/items'  
      And the request is sent to the server
     Then No errors are returned by server
  
  @MenuCycle_Create_a_MenuCycleItem 
  Scenario: POST- MenuCycleItem with Recipe
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and ''     
      And  the 'single' group '95' and '96' request sent to server 
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against a menucycle '/MenuCycles/' and '/items'      
      And  Item request contains mealpriod 39 and the 'Recipe' with id 898  	
     Then No errors are returned by server
      And user can get one of the menucycleitemid 
     When user issues 'DELETE' request against a menucycleitem '/MenuCycles/' and '/items'  
      And the request is sent to the server
     Then No errors are returned by server
  

  @MenuCycle_Create_a_MenuCycleItem 
  Scenario: POST- MenuCycleItem with Manu and recipe
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and ''     
      And  the 'single' group '95' and '96' request sent to server 
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against a menucycle '/MenuCycles/' and '/items'      
      And  Item request contains mealpriod 39 and the 'MenuRecipe' with mneu id 94 recipeid 898 
     Then No errors are returned by server
      And user can get one of the menucycleitemid 
     When user issues 'DELETE' request against a menucycleitem '/MenuCycles/' and '/items'  
      And the request is sent to the server
     Then No errors are returned by server
	 ######  Delete a menucycleitem which Doesn't exist #######
     When user issues 'DELETE' request against a menucycleitem '/MenuCycles/' and '/items'  
      And the request is sent to the server
     Then Not Found response returen by server 
  
