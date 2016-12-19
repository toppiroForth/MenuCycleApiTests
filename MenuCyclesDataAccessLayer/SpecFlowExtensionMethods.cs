using TechTalk.SpecFlow;

namespace MenuCyclesDataAccessLayer
{
    public static class SpecFlowExtensionMethods
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
