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
namespace MenuCycleApiTests_ci.Menus.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GETMenus")]
    public partial class GETMenusFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GETMenus.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GETMenus", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("GETMenus")]
        [NUnit.Framework.CategoryAttribute("getMenuproperties")]
        public virtual void GETMenus()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GETMenus", new string[] {
                        "getMenuproperties"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
testRunner.Given("user can access the MenuService API with userID \'pgreen\' and Org \'Fourth\' content" +
                    "Type \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
     testRunner.When("user issues \'GET\' request against the \'/Menus\' and \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "menuId",
                        "name",
                        "menuType"});
            table1.AddRow(new string[] {
                        "1",
                        "Menu1",
                        "1"});
            table1.AddRow(new string[] {
                        "2",
                        "Menu2",
                        "0"});
            table1.AddRow(new string[] {
                        "3",
                        "Menu3",
                        "1"});
            table1.AddRow(new string[] {
                        "5",
                        "Menu5",
                        "1"});
            table1.AddRow(new string[] {
                        "6",
                        "Menu6",
                        "1"});
            table1.AddRow(new string[] {
                        "7",
                        "Menu7",
                        "0"});
            table1.AddRow(new string[] {
                        "8",
                        "Menu8",
                        "0"});
            table1.AddRow(new string[] {
                        "10",
                        "Menu10",
                        "1"});
            table1.AddRow(new string[] {
                        "11",
                        "Menu11",
                        "1"});
            table1.AddRow(new string[] {
                        "12",
                        "Menu12",
                        "0"});
            table1.AddRow(new string[] {
                        "13",
                        "Menu13",
                        "0"});
            table1.AddRow(new string[] {
                        "14",
                        "Menu14",
                        "1"});
            table1.AddRow(new string[] {
                        "15",
                        "Menu15",
                        "0"});
            table1.AddRow(new string[] {
                        "16",
                        "Menu16",
                        "0"});
            table1.AddRow(new string[] {
                        "17",
                        "Menu17",
                        "1"});
            table1.AddRow(new string[] {
                        "18",
                        "Menu18",
                        "0"});
            table1.AddRow(new string[] {
                        "21",
                        "Menu21",
                        "1"});
            table1.AddRow(new string[] {
                        "22",
                        "Menu22",
                        "0"});
            table1.AddRow(new string[] {
                        "24",
                        "Menu24",
                        "1"});
            table1.AddRow(new string[] {
                        "25",
                        "Menu25",
                        "1"});
#line 10
      testRunner.And("the following Menus propertie collection is returned by the server", ((string)(null)), table1, "And ");
#line 33
    testRunner.And("the following Menu entities are class \'Menu\' and rel \'/rels/menu\'are returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "href",
                        "method",
                        "title",
                        "type"});
            table2.AddRow(new string[] {
                        "http://qai-menuservice.fourth.com//Menus",
                        "GET",
                        "",
                        "application/vnd.siren+json;"});
            table2.AddRow(new string[] {
                        "http://qai-menuservice.fourth.com//Menus?$skip=0&$top=20",
                        "GET",
                        "Current Page",
                        "application/vnd.siren+json;"});
            table2.AddRow(new string[] {
                        "http://qai-menuservice.fourth.com//Menus?$skip=20&$top=20",
                        "GET",
                        "Next Page",
                        "application/vnd.siren+json;"});
            table2.AddRow(new string[] {
                        "http://qai-menuservice.fourth.com//Menus?$skip=40&$top=20",
                        "GET",
                        "Last Page",
                        "application/vnd.siren+json;"});
#line 34
    testRunner.And("the follwing links are returned", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GET Single Menu")]
        [NUnit.Framework.CategoryAttribute("SingeMenu")]
        public virtual void GETSingleMenu()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GET Single Menu", new string[] {
                        "SingeMenu"});
#line 45
  this.ScenarioSetup(scenarioInfo);
#line 46
    testRunner.Given("user can access the MenuService API with userID \'pgreen\' and Org \'Fourth\' content" +
                    "Type \'application/vnd.siren+json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
     testRunner.When("user issues \'GET\' request against the \'/menus\' and \'/1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
      testRunner.And("the request is sent to the server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
     testRunner.Then("No errors are returned by server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "menuId",
                        "name",
                        "menuType"});
            table3.AddRow(new string[] {
                        "1",
                        "Menu1",
                        "1"});
#line 50
      testRunner.And("the following menu propertie are returned by the server", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Class",
                        "rel"});
            table4.AddRow(new string[] {
                        "Recipes",
                        "/rels/recipes"});
            table4.AddRow(new string[] {
                        "Groups",
                        "/rels/groups"});
#line 53
      testRunner.And("the following Menusentites entities are returned", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "href",
                        "method",
                        "title",
                        "type"});
            table5.AddRow(new string[] {
                        "http://qai-menuservice.fourth.com/Menus/1",
                        "GET",
                        "Menu",
                        "application/vnd.siren+json;"});
#line 57
      testRunner.And("the follwing links are returned", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
