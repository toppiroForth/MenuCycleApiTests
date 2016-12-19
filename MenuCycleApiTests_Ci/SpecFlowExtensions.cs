using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MenuCycleApiTests_ci
{
    public static class SpecFlowExtensions
    {


        public static void RemoveIfExists(this ScenarioContext scenarioContext, string key)
        {
            if (ScenarioContext.Current.ContainsKey(key))
            {
                ScenarioContext.Current.Remove(key);
            }
        }

        public static void AddNewRemoveExisting(this ScenarioContext scenarioContext, string key, object @object)
        {
            if (ScenarioContext.Current.ContainsKey(key))
            {
                ScenarioContext.Current.Remove(key);
            }
            ScenarioContext.Current.Add(key, @object);
        }
    }

}

