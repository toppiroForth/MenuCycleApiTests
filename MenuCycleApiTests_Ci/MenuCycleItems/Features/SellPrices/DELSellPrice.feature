

Feature: DEL-SellPrices

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

@delSellPrice 
Scenario: DEL-SellPrice 
    Given user can access the MenuService API with userID 'AutomationTestUser1' and Org 'organisationName' contentType 'application/vnd.siren+json' 	      
     When user issues 'DELETE' request against the sellPrices '/MenuCycles/' and '/items/' and '/Sellprices' added           
      And the request contains SellpriceModel 1 and tariffId 24 and value 10 and Vat 10 quantity 23 price 20 minprice 20 maxprice 10  
      And the request is sent to the server
     Then No errors are returned by server