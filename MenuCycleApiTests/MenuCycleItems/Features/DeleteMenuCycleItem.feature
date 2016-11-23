Feature: DeleteMenuCycleItem

Feature: UpdateSingelMenuItem

  Background: 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'PUT' request against the '/MenuCycles' and '/23/items'    
      And user update single item  with day 8 order 3 menuid 0 mealperiod 4 and recipeid 2          
      And the request is sent to the server
     Then No errors are returned by server
      And user can get one of the menucycleitemid 

   @Delete a menuCycle item 
   Scenario: DELETE- a MenuCycleItem
     Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'DELETE' request to delete last item against the '/MenuCycles' and '/23/items' 
	  And the request is sent to the server
	  Then No errors are returned by server