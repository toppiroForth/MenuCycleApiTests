using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApiTests.Domain;
using ApiTests.Domain.Siren;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ApiTests.MenuServiceIntegration.MealPeriods
{
    [Binding]
    public class MealPeriodSteps
    {
        [Then(@"the response contains the following Meal Periods")]
        public void ThenTheResponseContainsTheFollowingMealPeriods(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var mealPeriods = JsonConvert.DeserializeObject<PagedCollectionEntity<MenuServiceMealPeriodEntity>>(response.Content);
            int matchingMealPeriod = mealPeriods.entities.Sum(mealPeriod => table.Rows.Count(tableRow => tableRow["Name"] == mealPeriod.properties.Name));
            Assert.IsTrue(matchingMealPeriod == table.RowCount);
            Assert.IsTrue(matchingMealPeriod == mealPeriods.entities.Count);
        }

        [Then(@"the response contains the Meal Period below")]
        public void ThenTheResponseContainsTheMealPeriodBelow(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var mealPeriod = JsonConvert.DeserializeObject<MenuServiceMealPeriodEntity>(response.Content);
            var matchingCount = table.Rows.Count(tableRow => tableRow["Name"] == mealPeriod.properties.Name);
            Assert.IsTrue(matchingCount == table.RowCount);
        }

    }
}
