
Feature: MenuCycles

Background: 
 Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database

@MenuCycle_Collection
  Scenario: GET-MenuCycles collection properites and entities   
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and ''     
      And  the 'multiple' group request sent to server
     Then No errors are returned by server
      And user should get the list of  menuCycleId from response
	Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and ''     
      And  the 'multiple' group request sent to server
     Then No errors are returned by server
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/MenuCycles' and ''
      And the request is sent to the server
     Then No errors are returned by server
      And the following MenuCycle propertie collection is returned by the server
     | name                        | description          | parentId | isPublished | isMaster  | nonServingDays | 
     | Test verify                 | Test description     | 0        | false       | false     | 0              |
     | Test verify                 | Test description     | 0        | False       | False     | 0              |
     And the following entities class and rel are returned
      | class     | rel             | 
      | MenuCycle | /rels/menucycle |
	   And the follwing links properties are returned  
      | href                                                              | method     | title             |    type |
      | http://ci-menuservice.fourth.com//MenuCycles                      | GET        |                   |  application/vnd.siren+json;    |
	  #| http://ci-menuservice.fourth.com//MenuCycles?$skip=0&$top=20     | GET        |  Current Page     |  application/vnd.siren+json;    |
	  #| http://ci-menuservice.fourth.com//MenuCycles?$skip=20&$top=20    | GET        |  Next Page        |  application/vnd.siren+json;    |
	  #| http://ci-menuservice.fourth.com//MenuCycles?$skip=60&$top=20    | GET        |  Last Page        |  application/vnd.siren+json;    |
	 And the following Actions are returned 
	  | href                                        | method | title               | type                        | name       |
	  | http://ci-menuservice.fourth.com/MenuCycles | POST  | Create a menu cycle | application/vnd.siren+json; | Create     |
    

  @MenuCycle_SingleMenuCycle 
  Scenario: GET-SingleMenuCycle status Code and properties 
   Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and ''     
      And  the 'single' group request sent to server
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'GET' request to get recent record against the '/MenuCycles' and '' 
      And the request is sent to the server
     Then No errors are returned by server
      And the following MenuCycle properites is returned
      | name         | description       | parentId | isPublished | isMaster  | nonServingDays | 
      | Test verify  | Test description  | 0        | False       | false     | 0              |
     And the following MenuCycle single entities are returned
      | Class     | rel                       |
      | Items     | /rels/menucycle/items     | 
      | Groups    | /rels/menucycle/groups    | 
	  | Locations | /rels/menucycle/locations | 
	   And the following menucycle Actions entities are returned 
      | method | title                                            | type                        |
      | PUT    | Search for menus and recipes to add to the cycle | application/vnd.siren+json; |
      | PUT    | Updates menu cycle                               | application/vnd.siren+json; |
      | DELETE | Deletes menu cycle                               |application/vnd.siren+json;  |
	  
    



   
   
