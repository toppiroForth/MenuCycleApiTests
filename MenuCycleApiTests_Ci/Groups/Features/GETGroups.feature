Feature: GETGroups


@getGroupsCollection
  Scenario: GET Groups collection properites and entities    
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/Groups' and ''
      And the request is sent to the server
     Then No errors are returned by server
	  And user should get the first groupId from response
      And the following Group propertie collection is returned by the server
      | name       | 
      | Group One  | 
      | Group Two  | 
     And the following entities class and rel are returned
      | class      | rel           | 
      | Group      | /rels/group   | 
	  And the follwing links properties are returned  
	  | href                                                             | method     | title             |    type |
      |http://ci-menuservice.fourth.com//Groups                          | GET        |                   |  application/vnd.siren+json;    |

	@getSingleGroup
    Scenario: GET Group single properties and links
	Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the '/Groups' and ''
      And the request is sent to the server
     Then No errors are returned by server
	  And user should get the first groupId from response 
	Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	         
     When user issues 'GET' request against the single group '/Groups/' and '' 
	  And the request is sent to the server
     Then No errors are returned by server 	
	  And the following single group properites is returned
	  | name |
	  |Group One|
	   And the following 'href' links returned for single group
	   | href                                        | 
	   | http://ci-menuservice.fourth.com/Groups/{0} | 
	   | http://ci-menuservice.fourth.com/Groups     |    
	    And the follwing links properties are returned 
       | method | title    | type                        | 
       | GET    | Group    | application/vnd.siren+json; | 
       | GET    | Groups   | application/vnd.siren+json; | 
       