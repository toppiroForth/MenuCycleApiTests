Feature: DeleteMenuCycleItem

  Background:  
   Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database


   @Delete a menuCycle item 
   Scenario: DELETE- a MenuCycleItem
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














  





