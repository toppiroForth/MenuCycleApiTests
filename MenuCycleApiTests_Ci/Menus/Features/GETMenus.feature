Feature: GETMenus


@getMenuproperties 
Scenario: GETMenus
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/Menus' and ''
      And the request is sent to the server
     Then No errors are returned by server
	 And user should get the last menuId from response
      And the following Menus propertie collection is returned by the server
	 | name                                     | menuType | 
     | AutoMenu 1                               | 1        |
	 | AutoMenu 2                               | 1        |
	 | AutoMenu 3                               | 1        |
	 | AutoMenu 4                               | 1        |
	 
    And the following Menu entities are class 'Menu' and rel '/rels/menu'are returned
    And the follwing links properties are returned   
	  | href                                                     | method | title        | type                        | 
      | http://ci-menuservice.fourth.com//Menus                  | GET    |              | application/vnd.siren+json; | 
      #| http://ci-menuservice.fourth.com//Menus?$skip=0&$top=20  | GET    | Current Page | application/vnd.siren+json; | 
      #| http://ci-menuservice.fourth.com//Menus?$skip=20&$top=20 | GET    | Next Page    | application/vnd.siren+json; | 
      #| http://ci-menuservice.fourth.com//Menus?$skip=20&$top=20 | GET    | Last Page    | application/vnd.siren+json; | 
 
      
  @SingleMenu
  Scenario: GET Single Menu  
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/Menus' and ''
      And the request is sent to the server
     Then No errors are returned by server
	 And user should get the last menuId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against singel '/menus' and ''
      And the request is sent to the server
     Then No errors are returned by server
      And the following menu propertie are returned by the server
       | name         | menuType | 
       | AutoMenu 4   | 1        | 
      And the following Menusentites entities are returned 
	  | Class   | rel           |
	  | Recipes | /rels/recipes |
	  | Groups  | /rels/groups  |
	  And the following 'href' links returned for single menu
	   | href                                                |
	   | http://ci-menuservice.fourth.com/Menus/{0}/Recipes  | 
	   | http://ci-menuservice.fourth.com/Menus/{0}/Groups   | 
      And the follwing links are returned   
      | href                                        | method | title | type                         | 
      | http://ci-menuservice.fourth.com/Menus      | GET    | Menus  | application/vnd.siren+json; | 
	  | http://ci-menuservice.fourth.com/Menus/{0}  | GET    | Menu  | application/vnd.siren+json;  | 



  
  