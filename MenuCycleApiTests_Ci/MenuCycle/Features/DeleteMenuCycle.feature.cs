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
    [NUnit.Framework.DescriptionAttribute("Delete a MenuCycles")]
    public partial class DeleteAMenuCyclesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DeleteMenuCycle.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Delete a MenuCycles", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("DELETE- a MenuCycles")]
        [NUnit.Framework.CategoryAttribute("MenuCycle_Delete")]
        public virtual void DELETE_AMenuCycles()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DELETE- a MenuCycles", new string[] {
                        "MenuCycle_Delete"});
#line 5
  this.ScenarioSetup(scenarioInfo);
#line 6
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
    testRunner.And("the \'single\' group \'95\' and \'96\' request sent to server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
      testRunner.And("user should get the last menuCycleId from response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
     testRunner.When("user issues \'DELETE\' request to delete last record against the \'/MenuCycles\' and " +
                    "\'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
   testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DELETE- a MenuCycles Which does not Exits")]
        [NUnit.Framework.CategoryAttribute("NotFound")]
        public virtual void DELETE_AMenuCyclesWhichDoesNotExits()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DELETE- a MenuCycles Which does not Exits", new string[] {
                        "NotFound"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
    testRunner.And("the \'single\' group \'95\' and \'96\' request sent to server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
      testRunner.And("user should get the last menuCycleId from response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
     testRunner.When("user issues \'DELETE\' request to delete last record against the \'/MenuCycles\' and " +
                    "\'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
  testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
     testRunner.When("user issues \'DELETE\' request to delete last record against the \'/MenuCycles\' and " +
                    "\'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
     testRunner.Then("Not Found response returen by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
