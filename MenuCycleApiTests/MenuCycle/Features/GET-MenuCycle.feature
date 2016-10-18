
Feature: MenuCycles

@MenuCycle_Collection
  Scenario: GET-MenuCycles collection properites   
     Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/MenuCycles' and ''
      And the request is sent to the server
     Then No errors are returned by server
      And the following MenuCycle propertie collection is returned by the server
      | menuCycleId | name        | description | parentId | isPublished | isMaster | nonServingDays | 
      | 10          | MenuCycle10 | MC Desc10   | 0        | False       | True     | 0              | 
      | 14          | MenuCycle14 | MC Desc14   | 0        | False       | True     | 0              | 
      | 18          | MenuCycle18 | MC Desc18   | 0        | False       | True     | 0              | 
      | 20          | MenuCycle20 | MC Desc20   | 0        | False       | True     | 0              | 
      | 23          | MenuCycle23 | MC Desc23   | 0        | False       | True     | 0              | 
      | 25          | MenuCycle25 | MC Desc25   | 0        | False       | True     | 0              | 
      | 28          | MenuCycle28 | MC Desc28   | 0        | False       | True     | 0              | 
      | 1           | MenuCycle1  | MC Desc1    | 0        | False       | True     | 0              | 
      | 2           | MenuCycle2  | MC Desc2    | 0        | False       | True     | 0              | 
      | 3           | MenuCycle3  | MC Desc3    | 0        | False       | True     | 0              | 
      | 6           | MenuCycle6  | MC Desc6    | 0        | False       | True     | 0              | 
      | 7           | MenuCycle7  | MC Desc7    | 0        | False       | True     | 0              | 
      | 8           | MenuCycle8  | MC Desc8    | 0        | False       | True     | 0              | 
      | 9           | MenuCycle9  | MC Desc9    | 0        | False       | True     | 0              | 
      | 13          | MenuCycle13 | MC Desc13   | 0        | False       | True     | 0              | 
      | 17          | MenuCycle17 | MC Desc17   | 0        | False       | True     | 0              | 
      | 21          | MenuCycle21 | MC Desc21   | 0        | False       | True     | 0              | 
      | 22          | MenuCycle22 | MC Desc22   | 0        | False       | True     | 0              | 
      | 26          | MenuCycle26 | MC Desc26   | 0        | False       | True     | 0              | 
      | 27          | MenuCycle27 | MC Desc27   | 0        | False       | True     | 0              | 


  @MenuCycle_SingleMenuCycle 
  Scenario: GET-SingleMenuCycle status Code and properties 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	   
     When user issues 'GET' request against the '/MenuCycles' and '/2'
      And the request is sent to the server
     Then No errors are returned by server
      And the following MenuCycle properites is returned
      | menuCycleId | name       | description | parentId | isPublished | isMaster | nonServingDays | 
      |      2      | MenuCycle2 | MC Desc2    | 0        | false       | true     | 0              | 
     
   
    

   @MenuCycle_Entities
  Scenario: GET-MenuCycle Entities  
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	   
     When user issues 'GET' request against the '/MenuCycles' and ''
      And the request is sent to the server
     Then No errors are returned by server
      And the following MenuCycle entities are returned
      | class     | rel             | 
      | MenuCycle | /rels/MenuCycle | 
	  And the follwing links are returned 
      | href                                                             | method     | title             |    type |
      | http://menuservice.starchef.net//MenuCycles                      | GET        |                   |  application/vnd.siren+json;    |
	  | http://menuservice.starchef.net//MenuCycles?$skip=0&$top=20      | GET        |  Current Page     |  application/vnd.siren+json;    |
	  | http://menuservice.starchef.net//MenuCycles?$skip=20&$top=20     | GET        |  Next Page        |  application/vnd.siren+json;    |
	  | http://menuservice.starchef.net//MenuCycles?$skip=60&$top=20     | GET        |  Last Page        |  application/vnd.siren+json;    |
	 And the following Actions are returned 
	  | href                                       | method | title               | type                        | name       |
	  | http://menuservice.starchef.net/MenuCycles | POST   | Create a menu cycle | application/vnd.siren+json; | Create     |


     @MenuCycle_NotFound 
  Scenario: GET-MenuCycle NotFound 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	   
     When user issues 'GET' request against the '/MenuCycles' and '/110'
      And the request is sent to the server
     Then No record found exception returned by server




   
    