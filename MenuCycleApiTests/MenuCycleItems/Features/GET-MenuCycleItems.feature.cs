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
    [NUnit.Framework.DescriptionAttribute("MenuCycleItemCollections")]
    public partial class MenuCycleItemCollectionsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GET-MenuCycleItems.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MenuCycleItemCollections", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("GET-MenuCycleItems collection properites")]
        [NUnit.Framework.CategoryAttribute("MenuCycleItem_Collection")]
        public virtual void GET_MenuCycleItemsCollectionProperites()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET-MenuCycleItems collection properites", new string[] {
                        "MenuCycleItem_Collection"});
#line 5
  this.ScenarioSetup(scenarioInfo);
#line 6
     testRunner.Given("user can access the MenuService API with userID \'pgreen\' and Org \'Fourth\' content" +
                    "Type \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
     testRunner.When("user issues \'GET\' request against the \'/MenuCycles\' and \'/1/items\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "menuCycleItemId",
                        "day",
                        "order",
                        "menuCycleItemType",
                        "menuType",
                        "menuName",
                        "course",
                        "menuId",
                        "mealPeriodId",
                        "mealPeriodName",
                        "parentId",
                        "recipeId",
                        "recipeName",
                        "cost",
                        "costQuantity",
                        "costUnitOfMeasure"});
            table1.AddRow(new string[] {
                        "10",
                        "2",
                        "10",
                        "1",
                        "0",
                        "Menu4",
                        "Breakfast",
                        "4",
                        "1",
                        "Breakfast",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
#line 10
      testRunner.And("the following MenuCycleitem propertie collection is returned", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion