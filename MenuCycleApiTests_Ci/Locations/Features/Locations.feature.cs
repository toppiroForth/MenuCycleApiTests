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
namespace MenuCycleApiTests_ci.Locations.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GetLocations")]
    public partial class GetLocationsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Locations.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetLocations", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GET Locations")]
        [NUnit.Framework.CategoryAttribute("RecipeCollection")]
        public virtual void GETLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET Locations", new string[] {
                        "RecipeCollection"});
#line 4
  this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
     testRunner.When("user issues \'GET\' request against the \'/locations\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
   testRunner.And("user should get the first locationId from response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "isDeleted",
                        "isActive"});
            table1.AddRow(new string[] {
                        "Loc 1",
                        "false",
                        "false"});
            table1.AddRow(new string[] {
                        "Loc 2",
                        "false",
                        "false"});
#line 10
   testRunner.And("the following locations propertie collection is returned by the server", ((string)(null)), table1, "And ");
#line 14
      testRunner.And("the following entities class \'Location\' and rel \'/rels/location\'are returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "href"});
            table2.AddRow(new string[] {
                        "http://ci-menuservice.fourth.com/Locations"});
#line 15
      testRunner.And("the follwing links are returned for recipes", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "method",
                        "title",
                        "type"});
            table3.AddRow(new string[] {
                        "GET",
                        "",
                        "application/vnd.siren+json;"});
#line 18
      testRunner.And("the follwing links properties are returned", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GET Single Location")]
        [NUnit.Framework.CategoryAttribute("SingleRecipe")]
        public virtual void GETSingleLocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET Single Location", new string[] {
                        "SingleRecipe"});
#line 23
  this.ScenarioSetup(scenarioInfo);
#line 24
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
     testRunner.When("user issues \'GET\' request against the \'/locations\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
   testRunner.And("user should get the first locationId from response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
  testRunner.When("user issues \'GET\' request against the single \'/locations/\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name"});
            table4.AddRow(new string[] {
                        "Loc 1"});
#line 33
    testRunner.And("the following single location properties are returned", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "href"});
            table5.AddRow(new string[] {
                        "http://ci-menuservice.fourth.com/Locations/{0}"});
            table5.AddRow(new string[] {
                        "http://ci-menuservice.fourth.com/Locations"});
#line 36
      testRunner.And("the following \'href\' links returned for single recipe", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "method",
                        "title",
                        "type"});
            table6.AddRow(new string[] {
                        "GET",
                        "Location",
                        "application/vnd.siren+json;"});
            table6.AddRow(new string[] {
                        "GET",
                        "Locations",
                        "application/vnd.siren+json;"});
#line 40
      testRunner.And("the follwing links properties are returned", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
