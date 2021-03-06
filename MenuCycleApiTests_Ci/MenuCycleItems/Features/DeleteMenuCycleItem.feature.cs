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
namespace MenuCycleApiTests_ci.MenuCycleItems.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DeleteMenuCycleItem")]
    public partial class DeleteMenuCycleItemFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DeleteMenuCycleItem.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DeleteMenuCycleItem", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 3
  #line 4
   testRunner.Given("the executable Menuservice stored procedure \'sp_delete_menucycle_by_customer_id\' " +
                    "with id \'39\' is executed against Staging Database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DELETE- a MenuCycleItem")]
        [NUnit.Framework.CategoryAttribute("Delete")]
        [NUnit.Framework.CategoryAttribute("a")]
        [NUnit.Framework.CategoryAttribute("menuCycle")]
        [NUnit.Framework.CategoryAttribute("item")]
        public virtual void DELETE_AMenuCycleItem()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DELETE- a MenuCycleItem", new string[] {
                        "Delete",
                        "a",
                        "menuCycle",
                        "item"});
#line 8
   this.ScenarioSetup(scenarioInfo);
#line 3
  this.FeatureBackground();
#line 9
     testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
      testRunner.And("the \'single\' group \'95\' and \'96\' request sent to server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
      testRunner.And("user should get the last menuCycleId from response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.Given("user can access the MenuService API with userID \'AutomationTestUser1\' and Org \'or" +
                    "ganisationName\' contentType \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
     testRunner.When("user issues \'POST\' request against a menucycle \'/MenuCycles/\' and \'/items\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
      testRunner.And("Item request contains mealpriod 39 and the \'Recipe\' with id 898", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
      testRunner.And("user can get one of the menucycleitemid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
  testRunner.When("user issues \'DELETE\' request against a menucycleitem \'/MenuCycles/\' and \'/items\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
