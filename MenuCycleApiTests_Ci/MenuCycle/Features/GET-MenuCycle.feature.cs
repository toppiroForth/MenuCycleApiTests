﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MenuCycleApiTests_ci.MenuCycle.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MenuCycles")]
    public partial class MenuCyclesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GET-MenuCycle.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MenuCycles", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 6
 testRunner.Given("the executable Menuservice stored procedure \'sp_delete_menucycle_by_customer_id\' " +
                    "with id \'39\' is executed against Staging Database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GET-MenuCycles collection properites and entities")]
        [NUnit.Framework.CategoryAttribute("MenuCycle_Collection")]
        public virtual void GET_MenuCyclesCollectionProperitesAndEntities()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET-MenuCycles collection properites and entities", new string[] {
                        "MenuCycle_Collection"});
#line 9
  this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 10
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
      testRunner.And("the \'multiple\' group \'95\' and \'96\' request sent to server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
      testRunner.And("user should get the list of  menuCycleId from response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
      testRunner.And("the \'multiple\' group \'95\' and \'96\' request sent to server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
     testRunner.When("user issues \'GET\' request against the \'/MenuCycles\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "description",
                        "parentId",
                        "isPublished",
                        "isMaster",
                        "nonServingDays"});
            table1.AddRow(new string[] {
                        "Test verify",
                        "Test description",
                        "0",
                        "false",
                        "false",
                        "0"});
            table1.AddRow(new string[] {
                        "Test verify",
                        "Test description",
                        "0",
                        "False",
                        "False",
                        "0"});
#line 23
      testRunner.And("the following MenuCycle propertie collection is returned by the server", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "class",
                        "rel"});
            table2.AddRow(new string[] {
                        "MenuCycle",
                        "/rels/menucycle"});
#line 27
     testRunner.And("the following entities class and rel are returned", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "href",
                        "method",
                        "title",
                        "type"});
            table3.AddRow(new string[] {
                        "http://ci-menuservice.fourth.com//MenuCycles",
                        "GET",
                        "",
                        "application/vnd.siren+json;"});
#line 30
    testRunner.And("the follwing links properties are returned", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "href",
                        "method",
                        "title",
                        "type",
                        "name"});
            table4.AddRow(new string[] {
                        "http://ci-menuservice.fourth.com/MenuCycles",
                        "POST",
                        "Create a menu cycle",
                        "application/vnd.siren+json;",
                        "Create"});
#line 36
  testRunner.And("the following Actions are returned", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GET-SingleMenuCycle status Code and properties")]
        [NUnit.Framework.CategoryAttribute("MenuCycle_SingleMenuCycle")]
        public virtual void GET_SingleMenuCycleStatusCodeAndProperties()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET-SingleMenuCycle status Code and properties", new string[] {
                        "MenuCycle_SingleMenuCycle"});
#line 42
  this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 43
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
      testRunner.And("the \'single\' group \'95\' and \'96\' request sent to server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
      testRunner.And("user should get the last menuCycleId from response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
     testRunner.When("user issues \'GET\' request to get recent record against the \'/MenuCycles\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "description",
                        "parentId",
                        "isPublished",
                        "isMaster",
                        "nonServingDays"});
            table5.AddRow(new string[] {
                        "Test verify",
                        "Test description",
                        "0",
                        "False",
                        "false",
                        "0"});
#line 52
      testRunner.And("the following MenuCycle properites is returned", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Class",
                        "rel"});
            table6.AddRow(new string[] {
                        "Items",
                        "/rels/menucycle/items"});
            table6.AddRow(new string[] {
                        "Groups",
                        "/rels/menucycle/groups"});
            table6.AddRow(new string[] {
                        "Locations",
                        "/rels/menucycle/locations"});
#line 55
     testRunner.And("the following MenuCycle single entities are returned", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "method",
                        "title",
                        "type"});
            table7.AddRow(new string[] {
                        "PUT",
                        "Search for menus and recipes to add to the cycle",
                        "application/vnd.siren+json;"});
            table7.AddRow(new string[] {
                        "PUT",
                        "Updates menu cycle",
                        "application/vnd.siren+json;"});
            table7.AddRow(new string[] {
                        "DELETE",
                        "Deletes menu cycle",
                        "application/vnd.siren+json;"});
#line 60
    testRunner.And("the following menucycle Actions entities are returned", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
