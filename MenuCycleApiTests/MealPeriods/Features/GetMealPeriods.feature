Feature: GetMealPeriods
	
@mytag
Scenario: GET MealPeriods 
	 Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/MealPeriods' and ''
      And the request is sent to the server
     Then No errors are returned by server
      And the following MealPeriod propertie collection is returned by the server
	  | mealperiodId | name      |
	  | 1            | Breakfast |
	  | 2            | Lunch     |
	  | 3            | Dinner    |
	  | 4            | All-day dining|
    And the following MealPeriod entities class 'MealPeriod' and rel '/rels/mealperiod'are returned
    And the follwing links are returned   
	| href                                                                   | method | title        | type                        | 
    | http://ci-menuservice.fourth.com//MealPeriods                          | GET    |              | application/vnd.siren+json; |          
	
@SingeMealPeriod	
Scenario: GET Single MealPeriods 
	 Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/MealPeriods' and ''
      And the request is sent to the server
     Then No errors are returned by server
      And the following MealPeriod propertie collection is returned by the server
	  | mealperiodId | name      |
	  | 1            | Breakfast |
	  | 2            | Lunch     |
	  | 3            | Dinner    |
	  | 4            | All-day dining|
    And the following MealPeriod entities class 'MealPeriod' and rel '/rels/mealperiod'are returned
    And the follwing links are returned   
	| href                                                                   | method | title        | type                        | 
    | http://ci-menuservice.fourth.com//MealPeriods                          | GET    |              | application/vnd.siren+json; |          
		   