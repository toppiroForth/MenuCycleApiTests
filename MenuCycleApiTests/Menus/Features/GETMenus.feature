Feature: GETMenus


@getMenuproperties 
Scenario: GETMenus
Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/Menus' and ''
      And the request is sent to the server
     Then No errors are returned by server
      And the following Menus propertie collection is returned by the server
	  | menuId | name   | menuType | 
      | 1      | Menu1  | 1        | 
      | 2      | Menu2  | 0        | 
      | 3      | Menu3  | 1        | 
      | 5      | Menu5  | 1        | 
      | 6      | Menu6  | 1        | 
      | 7      | Menu7  | 0        | 
      | 8      | Menu8  | 0        | 
      | 10     | Menu10 | 1        | 
      | 11     | Menu11 | 1        | 
      | 12     | Menu12 | 0        | 
      | 13     | Menu13 | 0        | 
      | 14     | Menu14 | 1        | 
      | 15     | Menu15 | 0        | 
      | 16     | Menu16 | 0        | 
      | 17     | Menu17 | 1        | 
      | 18     | Menu18 | 0        | 
      | 21     | Menu21 | 1        | 
      | 22     | Menu22 | 0        | 
      | 24     | Menu24 | 1        | 
      | 25     | Menu25 | 1        | 

    And the following Menu entities are class 'Menu' and rel '/rels/menu'are returned
    And the follwing links are returned   
	  | href                                                      | method | title        | type                        | 
      | http://qai-menuservice.fourth.com//Menus                  | GET    |              | application/vnd.siren+json; | 
      | http://qai-menuservice.fourth.com//Menus?$skip=0&$top=20  | GET    | Current Page | application/vnd.siren+json; | 
      | http://qai-menuservice.fourth.com//Menus?$skip=20&$top=20 | GET    | Next Page    | application/vnd.siren+json; | 
      | http://qai-menuservice.fourth.com//Menus?$skip=40&$top=20 | GET    | Last Page    | application/vnd.siren+json; | 
  


    
  @SingeMenu
  Scenario: GET Single Menu  
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/menus' and '/1'
      And the request is sent to the server
     Then No errors are returned by server
      And the following menu propertie are returned by the server
      | menuId | name  | menuType | 
      | 1      | Menu1 | 1        | 
      And the following Menusentites entities are returned 
	  | Class   | rel           |
	  | Recipes | /rels/recipes |
	  | Groups  | /rels/groups  |
      And the follwing links are returned   
      | href                                          | method | title | type                        | 
      | http://qai-menuservice.fourth.com/Menus/1     | GET    | Menu  | application/vnd.siren+json; | 
  
  