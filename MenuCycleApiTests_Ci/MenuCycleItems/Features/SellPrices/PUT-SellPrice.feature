

Feature:Update a SellPrice 

Background: 
    Given the executable Menuservice stored procedure 'sp_delete_menucycle_by_customer_id' with id '39' is executed against Staging Database
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

@PutSellPricesint
  Scenario: PUT_SellPrice with sellprice
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'PUT' request against the sellPrices '/MenuCycles/' and '/items/' and '/Sellprices' added         
      And the request contains with SellPriceModel 'FixedPrice' and tariffId 25 and value 10 and Vat 10 quantity 25 price 40 minprice 30 maxprice 50
      And the request is sent to the server
     Then No errors are returned by server
	Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'GET' request against the sellPrices '/MenuCycles/' and '/items/' and '/Sellprices' added    
      And the request is sent to the server
     Then No errors are returned by server
	  And the following itemSellPrice propertie collection is returned
	   | sellPricesModel | tariffId | value | vat   | quantity | price | minimumPrice | maximumPrice |
	   | FixedPrice      | 25       | 10.00 | 10.00 | 25       | 40.00 | 30.00        | 50.00        |
