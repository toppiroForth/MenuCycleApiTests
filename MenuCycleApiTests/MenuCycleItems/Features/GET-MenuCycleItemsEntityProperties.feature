
Feature: MenuCycleItemCollections

  Background: 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/23/items'      
      And  the 'Menu' with id 14 request contains the following body 
     Then No errors are returned by server
     When user issues 'GET' request against the '/MenuCycles' and '/23/items'
      And the request is sent to the server
     Then No errors are returned by server
      And user can get one of the menucycleitemid 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'PUT' request against the '/MenuCycles' and '/23/items'    
      And user update single item  with day 8 order 3 menuid 16 mealperiod 4 and recipeid 2          
      And the request is sent to the server
     Then No errors are returned by server  
  
  @MenuCycleItem_Collection
  Scenario: GET-MenuCycleItems collection properites   
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/MenuCycles' and '/23/items'
      And the request is sent to the server
     Then No errors are returned by server
      And the following MenuCycleitem propertie collection is returned
      | day | order | menuCycleItemType | menuType | menuName                                 | course | menuId | mealPeriodId | mealPeriodName | recipeId | recipeName                         | cost  | costQuantity | costUnitOfMeasure | 
      | 8   | 3     | 1                 | 0        | Das Rheingold Amphitheatre Bar Pre order |        | 16     | 4            | All-day dining |          |                                    |       |              |                   | 
      | 8   | 3     | 0                 | 0        |                                          |        | 0      | 4            | All-day dining | 150      | French 75                          | 56.83 | 1.0          | kg                | 
      | 8   | 3     | 0                 | 0        |                                          |        | 0      | 4            | All-day dining | 248      | Rocket Pesto                       | 48.45 | 1.0          | kg                | 
      | 8   | 3     | 0                 | 0        |                                          |        | 0      | 4            | All-day dining | 255      | Salad Garnish                      | 5.82  | 2.0          | kg                | 
      | 8   | 3     | 0                 | 0        |                                          |        | 0      | 4            | All-day dining | 301      | Tomato juice with celery garnish   | 31.89 | 4.0          | kg                | 
      | 8   | 3     | 0                 | 0        |                                          |        | 0      | 4            | All-day dining | 2        | _Apple Juice published to diff set | 58.35 | 3.0          | kg                | 
  
  
