Feature: CreateMenuCycleItem

@MenuCycle_Create_a_MenuCycleItem 
  Scenario: POST- MenuCycleItem with Manu 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/30/items'      
      And  the 'Menu' request contains the following body 
     Then No errors are returned by server
  
  @MenuCycle_Create_a_MenuCycleItem 
  Scenario: POST- MenuCycleItem with Recipe
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/30/items'      
      And  the 'Recipe' request contains the following body 
     Then No errors are returned by server
  
  @MenuCycle_Create_a_MenuCycleItem 
  Scenario: POST- MenuCycleItem with Manu and recipe
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/30/items'     
     And  the 'MenuRecipe' request contains the following body 
     Then No errors are returned by server
  

  @MenuCycleitem_withMenuRecipeNotAssociated
  Scenario: POST-FB- MenuCycleitem with menu and recipe not associated with user  
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against the '/MenuCycles' and '/30/items'   
      And  the 'MenuRecipe' not associated request contains the following body 
     Then bad request status are returned by server
