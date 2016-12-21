Feature: Delete a MenuCycles

	   
@MenuCycle_Delete
  Scenario: DELETE- a MenuCycles
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and ''  
	   And  the 'single' group '95' and '96' request sent to server        
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'DELETE' request to delete last record against the '/MenuCycles' and '' 
	  And the request is sent to the server
     Then No errors are returned by server

@NotFound
Scenario: DELETE- a MenuCycles Which does not Exits 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and ''     
	   And  the 'single' group '95' and '96' request sent to server  
     Then No errors are returned by server
      And user should get the last menuCycleId from response
	Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'DELETE' request to delete last record against the '/MenuCycles' and '' 
      And the request is sent to the server
     Then No errors are returned by server 
	 Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'DELETE' request to delete last record against the '/MenuCycles' and '' 
      And the request is sent to the server
     Then Not Found response returen by server 

 
  