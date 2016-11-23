﻿

Feature: Add a SellPrice

@PostSellPricesint
  Scenario: POST_SellPrice to an Item with sellpriceModel integer 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and '/30/items/1230/SellPrices'      
      And the request contains SellpriceModel 1 and tariffId 4 and value 10 and Vat 10 quantity 23 price 20 minprice 20 maxprice 10  
      And the request is sent to the server
     Then No errors are returned by server
  
  @PostSellPricesstring
  Scenario: POST_SellPrice to an Item with sellpriceModel string 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	      
     When user issues 'POST' request against the '/MenuCycles' and '/30/items/1230/SellPrices'      
      And the request contains with SellPriceModel 'FixedPrice' and tariffId 3 and value 10 and Vat 10 quantity 23 price 20 minprice 20 maxprice 10
      And the request is sent to the server
     Then No errors are returned by server
  
  
