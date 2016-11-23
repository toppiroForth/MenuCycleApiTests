
Feature: MenuCycleItemEntites 

  Background: 

    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'PUT' request against the '/MenuCycles' and '/23/items'    
      And user update single item  with day 8 order 3 menuid 16 mealperiod 4 and recipeid 2          
      And the request is sent to the server
     Then No errors are returned by server  
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/23/items'   
      And  the 'MenuRecipe' with id 3102 request contains the following body
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/23/items'   
      And  the 'MenuRecipe' with id 3102 request contains the following body
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/23/items'   
      And  the 'MenuRecipe' with id 3102 request contains the following body
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/23/items'   
      And  the 'MenuRecipe' with id 3102 request contains the following body

  
  @MenuCycle_Entities
  Scenario: GET-MenuCycleItem  Entities links and Actions  
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	   
     When user issues 'GET' request against the '/MenuCycles' and '/23/items'
      And the request is sent to the server
     Then No errors are returned by server
      And the following MenuCycleItem entities are returned
      | class         | rel                  | 
      | MenuCycleItem | /rels/menucycle/item | 
      And the follwing links are returned 
      | href                                                                   | method | title        | type                        | 
      | http://ci-menuservice.fourth.com//MenuCycles/23/Items                  | GET    |              | application/vnd.siren+json; | 
      | http://ci-menuservice.fourth.com//MenuCycles/23/Items?$skip=0&$top=20  | GET    | Current Page | application/vnd.siren+json; | 
      | http://ci-menuservice.fourth.com//MenuCycles/23/Items?$skip=20&$top=20 | GET    | Next Page    | application/vnd.siren+json; | 
      | http://ci-menuservice.fourth.com//MenuCycles/23/Items?$skip=20&$top=20 | GET    | Last Page    | application/vnd.siren+json; | 
      And the following Actions are returned 
      | href                                                 | method | title                       | type                        | name        | 
      | http://ci-menuservice.fourth.com/MenuCycles/23/Items | POST   | Creates menu cycle's items  | application/vnd.siren+json; | CreateItems | 
      | http://ci-menuservice.fourth.com/MenuCycles/23/Items | PUT    | Replaces menu cycle's items | application/vnd.siren+json; | UpdateItems | 
  
