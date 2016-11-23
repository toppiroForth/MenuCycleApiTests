
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTests.Domain;
using ApiTests.Domain.Siren;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using MenuCycleApiTests_ci;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System.Threading;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium.Remote;
using MenuCycleIntegrationTests.Pages;
using MenuCycleIntegrationTests.Base;
using OpenQA.Selenium.Chrome;
using MenuCycleIntegrationTests.Helpers;
using MenuCycleIntegrationTests.Config;
using System.Configuration;


namespace ApiTests.MenuServiceIntegration.Groups
{
    [Binding]
    public class GroupSteps : Base
    {

        [Then(@"the executable query '(.*)'AutomationApiGroupTest'(.*)' is executed against Staging Database")]
        public void ThenTheQueryIsExecutedAgainst(string query, string p1)
        {
            var queryResults = Helpers.GetValues(query).ToList();
            ScenarioContext.Current.AddNewRemoveExisting("queryResults", queryResults);
        }

        [Then(@"the returned '(.*)' are stored in the scenario context")]
        public void ThenTheReturnedAreStoredInTheScenarioContext(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all '(.*)' related data are cleared from '(.*)' database")]
        public void ThenAllRelatedDataAreClearedFromDatabase(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }


        //This is StarChef UI Scenarios
        [Given(@"I am logged in to StarChef with username '(.*)' and password '(.*)'")]
        public void GivenIAmLoggedInToStarChefWithUsernameAndPassword(string _userName, string _passWord)
        {


            //DesiredCapabilities ieCapabilities = DesiredCapabilities.InternetExplorer();
            //ieCapabilities.SetCapability("nativeEvents", false);
            //ieCapabilities.SetCapability("unexpectedAlertBehaviour", "accept");
            //ieCapabilities.SetCapability("ignoreProtectedModeSettings", true);
            //ieCapabilities.SetCapability("disable-popup-blocking", true);
            //ieCapabilities.SetCapability("enablePersistentHover", true);


          


            try
            {
                    string url = ConfigReader.InitilizeTest();
                    OpenBrowser(BrowserType.InternetExplorer);
                    DriverContext.Browser.GoToUrl(url);
                    DriverContext.Driver.Manage().Window.Maximize();
                    CurrentPage = GetInstance<LoginPage>();
                    CurrentPage = CurrentPage.As<LoginPage>().login(_userName, _passWord);
                    Thread.Sleep(3000);

                    if (Utils.isAlertDialogPresent(DriverContext.Driver))
                    {
                        IAlert alert = DriverContext.Driver.SwitchTo().Alert();
                        Console.WriteLine("this is the alert message " + alert.Text);
                        DriverContext.Driver.SwitchTo().Alert().Accept();
                    }
                    else
                    {
                        Console.WriteLine("try");
                    }
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception ******" + e.ToString());

            }

            finally
            {
                Thread.Sleep(2000);
                DriverContext.Driver.Quit();
             
            }






            // Assert.IsTrue(CurrentPage.As<WelComePage>().ImOnTheRightPage());



           


            //Accept if popup is available...
            // Utils.isAlertDialogPresent(DriverContext.Driver);
            //Thread.Sleep(5000);

        }


        [Given(@"the '(.*)' option is selected and its respective tab title '(.*)' is displayed")]
        public void GivenTheOptionIsSelectedAndItsRespectiveTabTitleIsDisplayed(string p0, string p1)
        {
            Console.WriteLine("Development ");
        }

        [Given(@"creates a new Group with the following details '(.*)'")]
        public void GivenCreatesANewGroupWithTheFollowingDetails(string p0, Table table)
        {
            Console.WriteLine("Development ");
        }

        [Given(@"The Starchef Menu Service API is accessed")]
        public void GivenTheStarchefMenuServiceAPIIsAccessed()
        {
            Console.WriteLine("Development ");
        }

        [When(@"the '(.*)' issues a '(.*)' request against Menu Service for '(.*)' on '(.*)' '(.*)'AutomationApiGroupTest'(.*)'")]
        public void WhenTheIssuesARequestAgainstMenuServiceForOnAutomationApiGroupTest(string p0, string p1, string p2, string p3, string p4, string p5)
        {
            Console.WriteLine("Development ");
        }


        [Then(@"No errors are returned by server")]
        public void ThenNoErrorsAreReturnedByServer()
        {
            Console.WriteLine("develop");
        }


        //This is Api Response 
        [Then(@"the response contains the following Groups")]
        public void ThenTheResponseContainsTheFollowingGroups(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var groups = JsonConvert.DeserializeObject<PagedCollectionEntity<MenuServiceGroupEntity>>(response.Content);
            int matchingGroup = groups.entities.Sum(group => table.Rows.Count(tableRow => tableRow["Name"] == group.properties.Name));
            Assert.IsTrue(matchingGroup == table.RowCount);
            //Assert.IsTrue(matchingGroup == groups.entities.Count); - will work properly when the deletion of Groups is reflected in the MenuServiceMain DB and API
        }

        [Then(@"the response contains the Group below")]
        public void ThenTheResponseContainsTheMealPeriodBelow(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var group = JsonConvert.DeserializeObject<MenuServiceGroupEntity>(response.Content);
            var matchingCount = table.Rows.Count(tableRow => tableRow["Name"] == group.properties.Name);
            Assert.IsTrue(matchingCount == table.RowCount);
        }



        public void OpenBrowser(BrowserType browserType)
        {

            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    //DriverContext.Driver = new InternetExplorerDriver(@"C:\Driver1");
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }




    }
}
