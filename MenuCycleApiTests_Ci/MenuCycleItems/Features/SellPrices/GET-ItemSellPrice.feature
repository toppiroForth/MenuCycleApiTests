Feature: GetItemSellPrice

Background: 
   Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and ''     
 	  And  the 'single' group '95' and '96' request sent to server 
     Then No errors are returned by server
      And user should get the last menuCycleId from response
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When  user issues 'POST' request against a menucycle '/MenuCycles/' and '/items'      
      And  Item request contains mealpriod 39 and the 'Recipe' with id 898  	
     Then No errors are returned by server
      And user can get one of the menucycleitemid 
	Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the sellPrices '/MenuCycles/' and '/items/' and '/Sellprices' added         
      And the request contains SellpriceModel 1 and tariffId 24 and value 10 and Vat 10 quantity 23 price 20 minprice 20 maxprice 10  
      And the request is sent to the server
     Then No errors are returned by server
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the sellPrices '/MenuCycles/' and '/items/' and '/Sellprices' added         
      And the request contains with SellPriceModel 'FixedPrice' and tariffId 23 and value 10 and Vat 10 quantity 23 price 20 minprice 20 maxprice 10
      And the request is sent to the server
     Then No errors are returned by server

@ItemSellPrices 
Scenario: GET_SellPrices properties actions and links 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the sellPrices '/MenuCycles/' and '/items/' and '/Sellprices' added    
      And the request is sent to the server
     Then No errors are returned by server
	  And the following itemSellPrice propertie collection is returned
	   | sellPricesModel | tariffId | value | vat   | quantity | price | minimumPrice | maximumPrice |
	   | FixedPrice      | 23       | 10.00 | 10.00 | 23       | 20.00 | 20.00        | 10.00        |
	   | FixedPrice      | 24       | 10.00 | 10.00 | 23       | 20.00 | 20.00        | 10.00        |               
      And the following sellprices entities are returned
      | class     | rel             | 
      | SellPrice | rels/menucycle/item/sellprice |  
	   And the follwing links properties are returned 
       | method     | title             |    type |
       | GET        |                   |  application/vnd.siren+json;    |
	   | GET        | Menu Cycle Item   |  application/vnd.siren+json;    |
	     
	  And the following 'href' links returned for sellprices 
	   | href                                                                   |
	   | http://ci-menuservice.fourth.com//MenuCycles/{0}/Items/{1}/SellPrices  |
	   | http://ci-menuservice.fourth.com/MenuCycles/{}/Items/{1}               | 
	                                                                         
	  #| http://ci-menuservice.fourth.com//MenuCycles?$skip=0&$top=20         | GET        |  Current Page     |  application/vnd.siren+json;    |
	  #| http://ci-menuservice.fourth.com//MenuCycles?$skip=20&$top=20        | GET        |  Next Page        |  application/vnd.siren+json;    |
	  #| http://ci-menuservice.fourth.com//MenuCycles?$skip=40&$top=20        | GET        |  Last Page        |  application/vnd.siren+json;    |
	  And the following 'Action href' links returned for sellprices 
	   | href                                                                  |
	   | http://ci-menuservice.fourth.com/MenuCycles/{0}/Items/{1}/SellPrices  |
	   | http://ci-menuservice.fourth.com/MenuCycles/{0}/Items/{1}/SellPrices  |                                                                       
 
	 And the following Actions are returned 
	  | method | title                             | type                        | name            |
      | POST   | Creates menu cycle item's prices  | application/vnd.siren+json; | CreateSellPrices|
	  | PUT    | Replaces menu cycle item's prices | application/vnd.siren+json; | UpdateSellPrices|
	Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database