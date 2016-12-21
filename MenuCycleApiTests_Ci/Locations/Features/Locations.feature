Feature: GetLocations

@RecipeCollection
  Scenario: GET Locations
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/locations' and ''
      And the request is sent to the server
     Then No errors are returned by server
	  And user should get the first locationId from response
	  And the following locations propertie collection is returned by the server
      | name  | isDeleted | isActive |
      | Loc 1 | false     | false    |
      | Loc 2 | false     | false    | 	
      And the following entities class 'Location' and rel '/rels/location'are returned
      And the follwing links are returned for recipes   
      | href                                          | 
      | http://ci-menuservice.fourth.com/Locations    |
      And the follwing links properties are returned 
      | method | title              | type                        |
      | GET    |                    | application/vnd.siren+json; |

  @SingleRecipe
  Scenario: GET Single Location 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/locations' and ''
      And the request is sent to the server
     Then No errors are returned by server
	  And user should get the first locationId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	           
	 When user issues 'GET' request against the single '/locations/' and '' 	 
      And the request is sent to the server
     Then No errors are returned by server
	   And the following single location properties are returned
      | name  | 
      | Loc 1 | 	  
      And the following 'href' links returned for single recipe
      | href                                             | 
      | http://ci-menuservice.fourth.com/Locations/{0} | 
      | http://ci-menuservice.fourth.com/Locations     | 
      And the follwing links properties are returned 
      | method | title                      | type                        |
      | GET    | Location                   | application/vnd.siren+json; |
      | GET    | Locations                  | application/vnd.siren+json; |
      