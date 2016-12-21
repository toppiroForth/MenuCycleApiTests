Feature: GetMealPeriods

@mytag
  Scenario: GET MealPeriods 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/mealperiods' and ''
      And the request is sent to the server
     Then No errors are returned by server
      And user should get the first mealPriodId from response
      And the following MealPeriod propertie collection is returned by the server
      | name         | 
      | MealPeriod 1 | 
      | MealPeriod 2 | 
      | MealPeriod 3 | 
      | MealPeriod 4 | 
      And the following MealPeriod entities class 'MealPeriod' and rel '/rels/mealperiod'are returned
      And the follwing links are returned   
      | href                                          | 
      | http://ci-menuservice.fourth.com//MealPeriods |
      And the follwing links properties are returned 
      | method | title              | type                        |
      | GET    |                    | application/vnd.siren+json; |

  @SingeMealPeriod	
  Scenario: GET Single MealPeriods 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/mealperiods' and ''
      And the request is sent to the server
     Then No errors are returned by server
      And user should get the first mealPriodId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the single '/mealperiods/' and '' 	 
      And the request is sent to the server
     Then No errors are returned by server
      And the following single mealperiod properties are returned
      | name         | 
      | MealPeriod 1 | 
      And the following 'href' links returned for single mealPeriod
      | href                                             | 
      | http://ci-menuservice.fourth.com/MealPeriods/{0} | 
      | http://ci-menuservice.fourth.com/MealPeriods     | 
      And the follwing links properties are returned 
      | method | title       | type                        | 
      | GET    | MealPeriod  | application/vnd.siren+json; | 
      | GET    | Meal Periods | application/vnd.siren+json; | 
  
