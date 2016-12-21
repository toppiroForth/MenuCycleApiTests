	

Feature: Update a MenuCycles
@MenuCycleUpdate
  Scenario: Update a MenuCycles
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and ''     
      And the 'multiple' group '95' and '96' request sent to server   
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'PUT' request to update last record against the '/MenuCycles' and '' 
      And the user update the record with name 'NameUpdated' description 'mydescription' and nonServingdata 25    
      And the request is sent to the server
     Then No errors are returned by server
	Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database
    
  
