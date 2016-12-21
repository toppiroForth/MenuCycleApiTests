Feature: GetRecipes

@mytag
  Scenario: GET Recipes
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/recipes' and ''
      And the request is sent to the server
     Then No errors are returned by server
	  And user should get the first recipeId from response
	  And the following recipes propertie collection is returned by the server
      | name          | 
      | AutoRecipe001 | 
      | AutoRecipe002 | 
      | AutoRecipe003 | 
      | AutoRecipe004 | 	 
      And the following entities class 'Recipe' and rel '/rels/recipe'are returned
      And the follwing links are returned 
      | href                                          | method | title | type                        | 
      | http://ci-menuservice.fourth.com/recipes      | GET    |       | application/vnd.siren+json; | 

  @SingeMealPeriod	
  Scenario: GET Single Recipe 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/recipes' and ''
      And the request is sent to the server
     Then No errors are returned by server
	  And user should get the first recipeId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	           
	 When user issues 'GET' request against the single '/recipes/' and '' 	 
      And the request is sent to the server
     Then No errors are returned by server
	  And the following single recipe properties are returned
      | name          | costUnitOfMeasure |
      | AutoRecipe001 | myC               |	  
      And the following 'href' links returned for single recipe
      | href                                             | 
      | http://ci-menuservice.fourth.com/Recipes/{0} | 
      | http://ci-menuservice.fourth.com/Recipes     | 
      And the follwing links properties are returned 
      | method | title                    | type                        |
      | GET    | Recipe                   | application/vnd.siren+json; |
      | GET    | Recipes                  | application/vnd.siren+json; |
      | GET    | Recipe information       | application/vnd.siren+json; |     
      | GET    | Nutrition information    | application/vnd.siren+json; |    
	  | GET    | Ingredient information   | application/vnd.siren+json; |    
	  | GET    |Intolerance information   | application/vnd.siren+json; |   
	  | GET    | Preparation information  | application/vnd.siren+json; |
      | GET    | TrafficLight information | application/vnd.siren+json; |


	  @recipeGroups 
      Scenario: GET Recipe groups 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/recipes' and ''
      And the request is sent to the server
     Then No errors are returned by server
	  And user should get the first recipeId from response
	Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	           
	 When user issues 'GET' request against the single '/recipes/' and '/Groups' 
	  And the request is sent to the server
     Then No errors are returned by server
	  And the following Group propertie collection is returned by the server
      | name       | 
      | Group One  | 
     And the following entities class and rel are returned
      | class      | rel           | 
      | Group      | /rels/group   | 
	  And the follwing links properties are returned  
	  | href                                                             | method     | title             |    type |
      |http://ci-menuservice.fourth.com//Groups                          | GET        |                   |  application/vnd.siren+json;    |



 