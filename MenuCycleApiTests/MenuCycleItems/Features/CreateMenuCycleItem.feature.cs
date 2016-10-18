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
namespace MenuCycleApiTests.MenuCycleItems.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateMenuCycleItem")]
    public partial class CreateMenuCycleItemFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateMenuCycleItem.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateMenuCycleItem", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("POST- MenuCycleItem with Manu")]
        [NUnit.Framework.CategoryAttribute("MenuCycle_Create_a_MenuCycleItem")]
        public virtual void POST_MenuCycleItemWithManu()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("POST- MenuCycleItem with Manu", new string[] {
                        "MenuCycle_Create_a_MenuCycleItem"});
#line 4
  this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given("user can access the MenuService API with userID \'pgreen\' and Org \'Fourth\' content" +
                    "Type \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'/30/items\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
      testRunner.And("the \'Menu\' request contains the following body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("POST- MenuCycleItem with Recipe")]
        [NUnit.Framework.CategoryAttribute("MenuCycle_Create_a_MenuCycleItem")]
        public virtual void POST_MenuCycleItemWithRecipe()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("POST- MenuCycleItem with Recipe", new string[] {
                        "MenuCycle_Create_a_MenuCycleItem"});
#line 11
  this.ScenarioSetup(scenarioInfo);
#line 12
    testRunner.Given("user can access the MenuService API with userID \'pgreen\' and Org \'Fourth\' content" +
                    "Type \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'/30/items\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
      testRunner.And("the \'Recipe\' request contains the following body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("POST- MenuCycleItem with Manu and recipe")]
        [NUnit.Framework.CategoryAttribute("MenuCycle_Create_a_MenuCycleItem")]
        public virtual void POST_MenuCycleItemWithManuAndRecipe()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("POST- MenuCycleItem with Manu and recipe", new string[] {
                        "MenuCycle_Create_a_MenuCycleItem"});
#line 18
  this.ScenarioSetup(scenarioInfo);
#line 19
    testRunner.Given("user can access the MenuService API with userID \'pgreen\' and Org \'Fourth\' content" +
                    "Type \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'/30/items\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
     testRunner.And("the \'MenuRecipe\' request contains the following body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("POST-FB- MenuCycleitem with menu and recipe not associated with user")]
        [NUnit.Framework.CategoryAttribute("MenuCycleitem_withMenuRecipeNotAssociated")]
        public virtual void POST_FB_MenuCycleitemWithMenuAndRecipeNotAssociatedWithUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("POST-FB- MenuCycleitem with menu and recipe not associated with user", new string[] {
                        "MenuCycleitem_withMenuRecipeNotAssociated"});
#line 26
  this.ScenarioSetup(scenarioInfo);
#line 27
    testRunner.Given("user can access the MenuService API with userID \'pgreen\' and Org \'Fourth\' content" +
                    "Type \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
     testRunner.When("user issues \'POST\' request against the \'/MenuCycles\' and \'/30/items\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
      testRunner.And("the \'MenuRecipe\' not associated request contains the following body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
     testRunner.Then("bad request status are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
