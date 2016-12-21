Feature: GetTariffs

@RecipeCollection
  Scenario: GET Tariffs Collection
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/Tariffs' and ''
      And the request is sent to the server
     Then No errors are returned by server
	 And user should get the first tarifflId from response
	 And the following tariffs propertie collection is returned by the server
      | name       |
      | Tariff 1   |
      | Tariff 2   |
      | Tariff 3   |
      | Tariff 4   |	 
      And the following entities class 'Tariff' and rel '/rels/tariff'are returned
      And the follwing links are returned 
      | href                                        |                    
      | http://ci-menuservice.fourth.com//Tariffs   | 
      And the follwing links properties are returned 
      | method | title              | type                        |
      | GET    |                    | application/vnd.siren+json; |
 
  @SingleRecipe
  Scenario: GET Single Tariff 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/Tariffs' and ''
      And the request is sent to the server
     Then No errors are returned by server
	  And user should get the first tarifflId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	           
	 When user issues 'GET' request against the single '/Tariffs/' and '' 	 
      And the request is sent to the server
     Then No errors are returned by server
	 And the following single tariff properties are returned
      | name     | description      |
      | Tariff 1 | AutomatioTariffs |	  
      And the following 'href' links returned for single recipe
      | href                                             | 
      | http://ci-menuservice.fourth.com/Tariffs/{0} | 
      | http://ci-menuservice.fourth.com/Tariffs     | 
      And the follwing links properties are returned 
      | method | title                    | type                        |
      | GET    | Tariff                   | application/vnd.siren+json; |
      | GET    | Tariffs                  | application/vnd.siren+json; |
      