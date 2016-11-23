
Feature: UpdateSingelMenuItem

  Background: 
      Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'PUT' request against the '/MenuCycles' and '/23/items'    
      And user update single item  with day 8 order 3 menuid 14 mealperiod 4 and recipeid 2          
      And the request is sent to the server
     When user issues 'GET' request against the '/MenuCycles' and '/23/items'
      And the request is sent to the server
     Then No errors are returned by server
      And user can get one of the menucycleitemid 
  
  @MenuCycle_Create_a_MenuCycleItem 
  Scenario Outline: PUT- Update SingelMenuItem record
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'PUT' request to update single item against the '/MenuCycles' and '/23/items'  
      And user update single item <day> <order> <menuId> <mealPeriodId> <recipeId> add to body            
      And the request is sent to the server
     Then No errors are returned by server 
    Examples: 
      | day | order  | menuId   | mealPeriodId | recipeId | 
      | 8   | 22     | 16       | 4            | 6        | 

