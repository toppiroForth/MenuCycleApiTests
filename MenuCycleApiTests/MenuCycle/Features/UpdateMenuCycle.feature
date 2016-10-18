	Feature: Update a MenuCycles

	
	@MenuCycle_Update
	  Scenario Outline: Update a MenuCycles
		 Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
		 When  user issues 'PUT' request against the '/MenuCycles' and '/30' 
		   And  the update request <name> <description> <nonServingdata> contains the following body    
		   And the request is sent to the server
		   Then No errors are returned by server
	Examples: 
	| name         | description                | nonServingdata  |
	| "Myname"     | "mydescription"            |  25             |


