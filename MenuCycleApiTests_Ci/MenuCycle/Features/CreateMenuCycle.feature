Feature:  Create a MenuCycles

 
@MenuCycle_Create_withMultiplegroups 
  Scenario: POST-Create a MenuCycles with Multiple groups 
    Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and ''	 
	  And  the 'multiple' group '95' and '96' request sent to server     
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database

  @MenuCycle_withGroupNotAssociated
  Scenario: POST-Create a MenuCycles with group not associated with user  
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	            
     When  user issues 'POST' request against the '/MenuCycles' and ''     
      And  the 'not associated' group '195' and '323' request sent to server   
     Then bad request status are returned by server

  

	 