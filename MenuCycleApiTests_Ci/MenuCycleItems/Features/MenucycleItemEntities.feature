
Feature: MenuCycleItemEntites 

  Background: 
    Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and ''     
      And the 'single' group request sent to server
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against a menucycle '/MenuCycles/' and '/items'      
      And Items request contains mealpriod 39 and the 'Menu' with id 94  
     Then No errors are returned by server

  @MenuCycle_Entities
  Scenario: GET-MenuCycleItem  Entities links and Actions  
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against a menucycle '/MenuCycles/' and '/items'     
      And the request is sent to the server
     Then No errors are returned by server
      And the following MenuCycleItem entities are returned
      | class         | rel                  | 
      | MenuCycleItem | /rels/menucycle/item | 

	  And the following 'href' links returned 
	   | href                                                                    |
	   | http://ci-menuservice.fourth.com//MenuCycles/{0}                        | 
	   | http://ci-menuservice.fourth.com//MenuCycles/{0}/Items                  | 
	   | http://ci-menuservice.fourth.com//MenuCycles/{0}/Items?$skip=0&$top=20  |
	   | http://ci-menuservice.fourth.com//MenuCycles/{0}/Items?$skip=20&$top=20 |
	   | http://ci-menuservice.fourth.com//MenuCycles/{0}/Items?$skip=20&$top=20 |

      And the follwing links properties are returned 
       | method | title        | type                        | 
       | GET    |              | application/vnd.siren+json; | 
       | GET    | Current Page | application/vnd.siren+json; | 
       | GET    | Next Page    | application/vnd.siren+json; | 
       | GET    | Last Page    | application/vnd.siren+json; | 
	   | GET    | Menu Cycle   | application/vnd.siren+json; | 
      And the following 'Action href' links returned 
	   | href                                                                    |
	   | http://ci-menuservice.fourth.com//MenuCycles/{0}/Items                  | 
	   | http://ci-menuservice.fourth.com//MenuCycles/{0}/Items                  | 

	  And the following Actions are returned 
     | method | title                       | type                        | name        | 
     | POST   | Creates menu cycle's items  | application/vnd.siren+json; | CreateItems | 
     | PUT    | Replaces menu cycle's items | application/vnd.siren+json; | UpdateItems | 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'PUT' request against a menucycle '/MenuCycles/' and '/items'      
      And user update single item  with day 8 order 3 menuid 94 mealperiod 40 and recipeid 900  	
     Then No errors are returned by server
      And user should get all menucyleitem id from the response
    ###### Delete a multiple menucycleitems ################
     When  user issues 'DELETE' request against a menucycle '/MenuCycles/' and '/items' 
      And user delete multiple menucycleitems 2
      And the request is sent to the server  
     Then No errors are returned by server
  
