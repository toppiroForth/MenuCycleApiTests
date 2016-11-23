Feature: CreateMenuCycleItem


@MenuCycle_Create_a_MenuCycleItem 
  Scenario: POST- MenuCycleItem with Manu 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/23/items'      
      And  the 'Menu' with id 14 request contains the following body 
     Then No errors are returned by server

  
  @MenuCycle_Create_a_MenuCycleItem 
  Scenario: POST- MenuCycleItem with Recipe
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/23/items'      
      And  the 'Recipe' with id 2 request contains the following body
     Then No errors are returned by server
  
  @MenuCycle_Create_a_MenuCycleItem 
  Scenario: POST- MenuCycleItem with Manu and recipe
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/23/items'     
      And  the 'MenuRecipe' with id 1402 request contains the following body
     Then No errors are returned by server
  
  @MenuCycleitem_withMenuRecipeNotAssociated
  Scenario: POST-FB- MenuCycleitem with menu and recipe not associated with user  
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/23/items'   
     And  the 'MenuRecipe' with id 1412 request contains the following body
     Then bad request status are returned by server
