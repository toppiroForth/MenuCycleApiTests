
Feature: MenuCycleItemCollections

@MenuCycleItem_Collection
  Scenario: GET-MenuCycleItems collection properites   
     Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/MenuCycles' and '/1/items'
      And the request is sent to the server
     Then No errors are returned by server
      And the following MenuCycleitem propertie collection is returned
      | menuCycleItemId | day | order | menuCycleItemType | menuType | menuName | course     | menuId | mealPeriodId | mealPeriodName | parentId | recipeId | recipeName | cost | costQuantity | costUnitOfMeasure |
      |       10        |   2 |  10   |  1                | 0        |  Menu4   | Breakfast  |   4    |     1        |     Breakfast  |          |          |            |      |              |                   |









	