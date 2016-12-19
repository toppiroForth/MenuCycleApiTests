
@RootSource
Feature: Root Resource Content

@Root_Resource
  Scenario: Root Resource 
    Given user can access the MenuService API with userID 'pgreen' and Org 'Fourth' contentType 'application/vnd.siren+json' 	   	       
     When user issues 'GET' request against the '' and ''
	 When the request is sent to the server
     Then No errors are returned by server
	 And the following root properites are returned
      | apiVersion | gitVersion       | buildNumber  | buildDate      | 
      | 1.0.0.0    | ec983aa          | 96           | 20161201083936 | 



	  