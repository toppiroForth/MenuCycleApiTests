Feature: Delete a MenuCycles

Background: 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and ''     
	  And  the 'single' group request sent to server
     Then No errors are returned by server
      And user should get the last menuCycleId from response
	   
@MenuCycle_Delete
  Scenario: DELETE- a MenuCycles
     Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'DELETE' request to delete last record against the '/MenuCycles' and '' 
	   And the request is sent to the server
       Then No errors are returned by server

 
