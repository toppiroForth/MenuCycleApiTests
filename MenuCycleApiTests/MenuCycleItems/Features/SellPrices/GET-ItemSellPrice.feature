Feature: GetItemSellPrice

Background: 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'PUT' request against the '/MenuCycles' and '/30/items/1230/SellPrices'      
      And the request contains SellpriceModel 1 and tariffId 4 and value 10 and Vat 10 quantity 23 price 20 minprice 20 maxprice 10  
      And the request is sent to the server
     Then No errors are returned by server

@ItemSellPrices 
Scenario: GET_UpdatedItemSellPrices properties actions and links 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the '/MenuCycles' and '/30/items/1230/SellPrices'        
      And the request is sent to the server
     Then No errors are returned by server
	  And the following itemSellPrice propertie collection is returned
	  | menuCycleId | menuCycleItemId | sellPricesModel | tariffId | value    | vat     | quantity | price   | minimumPrice     | maximumPrice |
	  | 30          | 1230            | FixedPrice      | 4        | 10.00    | 10.00   | 23       | 20.00    | 20.00           | 10.00        |
      And the following sellprices entities are returned
      | class     | rel             | 
      | SellPrice | /rels/SellPrice | 
	  And the follwing links are returned 
       | href                                                                 | method     | title             |    type |
       | http://ci-menuservice.fourth.com/MenuCycles/30/Items/1230/SellPrices | GET        |                   |  application/vnd.siren+json;    |
	  #| http://ci-menuservice.fourth.com//MenuCycles?$skip=0&$top=20        | GET        |  Current Page     |  application/vnd.siren+json;    |
	  #| http://ci-menuservice.fourth.com//MenuCycles?$skip=20&$top=20       | GET        |  Next Page        |  application/vnd.siren+json;    |
	  #| http://ci-menuservice.fourth.com//MenuCycles?$skip=40&$top=20       | GET        |  Last Page        |  application/vnd.siren+json;    |
	 And the following Actions are returned 
	  | href                                                                 | method | title                             | type                        | name            |
	  | http://ci-menuservice.fourth.com/MenuCycles/30/Items/1230/SellPrices | POST   | Creates menu cycle item's prices  | application/vnd.siren+json; | CreateSellPrices|
	  | http://ci-menuservice.fourth.com/MenuCycles/30/Items/1230/SellPrices | PUT    | Replaces menu cycle item's prices | application/vnd.siren+json; | UpdateSellPrices|
