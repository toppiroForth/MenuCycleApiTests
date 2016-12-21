Feature: GetSellPriceModels

@RecipeCollection
  Scenario: GET SellPriceModels
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/SellPriceModels' and ''
      And the request is sent to the server
     Then No errors are returned by server
	 And user should get the first SellPriceModelId from response
	 And the following sellPriceModels propertie collection is returned by the server
      | name       |
      | None       |
      | FixedPrice |
      | Margin     |
      | MarkUp     |	 
      And the following entities class 'SellPriceModel' and rel '/rels/sellpricemodel'are returned
      And the follwing links are returned 
      | href                                                |                    
      | http://ci-menuservice.fourth.com/SellPriceModels    | 
      And the follwing links properties are returned 
      | method | title              | type                        |
      | GET    |                    | application/vnd.siren+json; |
 
  #@SingleRecipe
  #Scenario: GET Single SellPriceModel 
  #  Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
  #   When user issues 'GET' request against the '/SellPriceModels' and ''
  #    And the request is sent to the server
  #   Then No errors are returned by server
	 # And user should get the first locationId from response
  #  Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	           
	 #When user issues 'GET' request against the single '/SellPriceModels/' and '' 	 
  #    And the request is sent to the server
  #   Then No errors are returned by server
	 #And the following single sellpriceModel properties are returned
  #    | name  | 
  #    |  | 	  
  #    And the following 'href' links returned for single recipe
  #    | href                                             | 
  #    | http://ci-menuservice.fourth.com/Locations/{0} | 
  #    | http://ci-menuservice.fourth.com/Locations     | 
  #    And the follwing links properties are returned 
  #    | method | title                      | type                        |
  #    | GET    | Location                   | application/vnd.siren+json; |
  #    | GET    | Locations                  | application/vnd.siren+json; |
  #    