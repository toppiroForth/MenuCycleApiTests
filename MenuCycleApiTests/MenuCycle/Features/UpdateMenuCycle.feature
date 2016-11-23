	
	
	Feature: Update a MenuCycles

	
	@MenuCycleUpdate
	  Scenario Outline: Update a MenuCycles
		 Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
		 When  user issues 'PUT' request against the '/MenuCycles' and '/28' 
		   And  the update request and <menuCycleid> <name> <description> <nonServingdata> contains the following body    
		   And the request is sent to the server
		   Then No errors are returned by server
	Examples: 
	|menuCycleid  | name            | description     | nonServingdata  |                 
	| 28          | "updated"       | "mydescription" |  25             |


