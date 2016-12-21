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
namespace MenuCycleApiTests_ci.Groups.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GETGroups")]
    public partial class GETGroupsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GETGroups.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GETGroups", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("GET Groups collection properites and entities")]
        [NUnit.Framework.CategoryAttribute("getGroupsCollection")]
        public virtual void GETGroupsCollectionProperitesAndEntities()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET Groups collection properites and entities", new string[] {
                        "getGroupsCollection"});
#line 5
  this.ScenarioSetup(scenarioInfo);
#line 6
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
     testRunner.When("user issues \'GET\' request against the \'/Groups\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
   testRunner.And("user should get the first groupId from response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name"});
            table1.AddRow(new string[] {
                        "Group One"});
            table1.AddRow(new string[] {
                        "Group Two"});
#line 11
      testRunner.And("the following Group propertie collection is returned by the server", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "class",
                        "rel"});
            table2.AddRow(new string[] {
                        "Group",
                        "/rels/group"});
#line 15
     testRunner.And("the following entities class and rel are returned", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "href",
                        "method",
                        "title",
                        "type"});
            table3.AddRow(new string[] {
                        "http://ci-menuservice.fourth.com//Groups",
                        "GET",
                        "",
                        "application/vnd.siren+json;"});
#line 18
   testRunner.And("the follwing links properties are returned", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GET Group single properties and links")]
        [NUnit.Framework.CategoryAttribute("getSingleGroup")]
        public virtual void GETGroupSinglePropertiesAndLinks()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET Group single properties and links", new string[] {
                        "getSingleGroup"});
#line 23
    this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
     testRunner.When("user issues \'GET\' request against the \'/Groups\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
   testRunner.And("user should get the first groupId from response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
     testRunner.When("user issues \'GET\' request against the single group \'/Groups/\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
   testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name"});
            table4.AddRow(new string[] {
                        "Group One"});
#line 33
   testRunner.And("the following single group properites is returned", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "href"});
            table5.AddRow(new string[] {
                        "http://ci-menuservice.fourth.com/Groups/{0}"});
            table5.AddRow(new string[] {
                        "http://ci-menuservice.fourth.com/Groups"});
#line 36
    testRunner.And("the following \'href\' links returned for single group", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "method",
                        "title",
                        "type"});
            table6.AddRow(new string[] {
                        "GET",
                        "Group",
                        "application/vnd.siren+json;"});
            table6.AddRow(new string[] {
                        "GET",
                        "Groups",
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
