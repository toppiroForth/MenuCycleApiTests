Feature:  Create a MenuCycles

    

@MenuCycle_Create_withMultiplegroups 
  Scenario: POST-Create a MenuCycles with Multiple groups 
     Given user can access the MenuService API with userID '0058E000001jqqsQAA' and Org '0012400000Ed3NCAAZ' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and ''     
	  And  the 'multiple' group request sent to server
     Then No errors are returned by server

 @MenuCycle_withGroupNotAssociated
  Scenario: POST-Create a MenuCycles with group not associated with user  
     Given user can access the MenuService API with userID '0058E000001jqqsQAA' and Org '0012400000Ed3NCAAZ' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and ''     
	  And  the 'not associated' group request sent to server
     Then bad request status are returned by server