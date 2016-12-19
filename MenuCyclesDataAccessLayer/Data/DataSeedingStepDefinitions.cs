using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MenuCyclesDataAccessLayer.Domain.Classes;
using TechTalk.SpecFlow;
using MenuCyclesDataAccessLayer.Domain;

namespace MenuCyclesDataAccessLayer
{
    [Binding]
    public class DataSeedingStepDefinitions
    {
        public SqlConnection _cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["StarChefLoginDbConnection"].ConnectionString);
        public int RecordIdentity { get; set; }

        public List<int> Ids { get; set; }

        [Given(@"the Customer/Organisation '(.*)' exists")]
        public void GivenTheOrganicationExists(string organisationName)
        {
            var guid = Guid.NewGuid();
            var now = DateTime.Now;
            var customer = new Customer()
            {
                Name = organisationName,
            };
            var customerOps = new CustomerOperations();
            if (!customerOps.CustomerExistsInDb(customer, _cnn))
            {
                customer.ExternalId = organisationName;
                customer.CreatedByExternalId = "admin";
                customer.UpdatedByExternalId = "admin";
                customer.DateCreatedUtc = now;
                customer.DateUpdatedUtc = now;
                int customerRedcordIdentity;
                customerOps.SaveAsNewCustomer(customer, _cnn, out customerRedcordIdentity);
                ScenarioContext.Current.AddNewRemoveExisting("customerRedcordIdentity", customerRedcordIdentity);
                customer.CustomerId = customerRedcordIdentity;
                ScenarioContext.Current.AddNewRemoveExisting("customer", customer);
            }
        }

        [Given(@"the Customer has a Location called '(.*)'")]
        public void GivenTheCustomerHasALocationCalled(string locationName)
        {
            var customer = ScenarioContext.Current.Get<Customer>("customer");
            var guid = Guid.NewGuid();
            var now = DateTime.Now;
            var location = new Location(customer)
            {
                Name = locationName
            };

            var locationOps = new LocationOperations();
            if (!locationOps.LocationExistsInDb(location, _cnn))
            {
                location.ExternalId = guid;
                location.CreatedByExternalId = "admin";
                location.UpdatedByExternalId = "admin";
                location.DateCreatedUtc = now;
                location.DateUpdatedUtc = now;
                int locationRedcordIdentity;
                locationOps.SaveAsNewLocation(location, _cnn, out locationRedcordIdentity);
                ScenarioContext.Current.AddNewRemoveExisting("locationRedcordIdentity", locationRedcordIdentity);
                location.LocationId = locationRedcordIdentity;
                ScenarioContext.Current.AddNewRemoveExisting("location", location);
            }
        }

        [Given(@"the Customer has the following Locations")]
        public void GivenTheCustomerHasTheFollowingLocations(Table table)
        {
            var customer = ScenarioContext.Current.Get<Customer>("customer");
            var now = DateTime.Now;
            var locationIds = new List<int>();
            var locations = new List<Location>();
            foreach (var tableRow in table.Rows)
            {
                var location = new Location(customer)
                {
                    Name = tableRow["Name"]
                };
                var locationOps = new LocationOperations();
                if (!locationOps.LocationExistsInDb(location, _cnn))
                {
                    location.ExternalId = Guid.NewGuid();
                    location.CreatedByExternalId = "admin";
                    location.UpdatedByExternalId = "admin";
                    location.DateCreatedUtc = now;
                    location.DateUpdatedUtc = now;
                    int locationRedcordIdentity;
                    locationOps.SaveAsNewLocation(location, _cnn, out locationRedcordIdentity);
                    locationIds.Add(locationRedcordIdentity);
                    location.LocationId = locationRedcordIdentity;
                    locations.Add(location);
                }
            }
            ScenarioContext.Current.AddNewRemoveExisting("locationIds", locationIds);
            ScenarioContext.Current.AddNewRemoveExisting("locations", locations);
        }

        [Given(@"the Customer has a Group called '(.*)'")]
        public void GivenTheCustomerHasAGroupCalled(string groupName)
        {
            var customer = ScenarioContext.Current.Get<Customer>("customer");
            var guid = Guid.NewGuid();
            var now = DateTime.Now;
            var group = new Group(customer)
            {
                Name = groupName
            };

            var groupOps = new GroupOperations();
            if (!groupOps.GroupExistsInDb(group, _cnn))
            {
                group.ExternalId = guid;
                group.CreatedByExternalId = "admin";
                group.UpdatedByExternalId = "admin";
                group.DateCreatedUtc = now;
                group.DateUpdatedUtc = now;
                int groupRedcordIdentity;
                groupOps.SaveAsNewLocation(group, _cnn, out groupRedcordIdentity);
                ScenarioContext.Current.AddNewRemoveExisting("groupRedcordIdentity", groupRedcordIdentity);
                group.GroupId = groupRedcordIdentity;
                ScenarioContext.Current.AddNewRemoveExisting("group", group);
            }
        }

        [Given(@"the Customer has the following Groups")]
        public void GivenTheCustomerHasTheFollowingGroups(Table table)
        {
            var customer = ScenarioContext.Current.Get<Customer>("customer");
            var now = DateTime.Now;
            var groupIds = new List<int>();
            var groups = new List<Group>();
            foreach (var tableRow in table.Rows)
            {
                var group = new Group(customer)
                {
                    Name = tableRow["Name"]
                };
                var groupOps = new GroupOperations();
                if (!groupOps.GroupExistsInDb(group, _cnn))
                {
                    group.ExternalId = Guid.NewGuid();
                    group.CreatedByExternalId = "admin";
                    group.UpdatedByExternalId = "admin";
                    group.DateCreatedUtc = now;
                    group.DateUpdatedUtc = now;
                    int groupRedcordIdentity;
                    groupOps.SaveAsNewLocation(group, _cnn, out groupRedcordIdentity);
                    groupIds.Add(groupRedcordIdentity);
                    group.GroupId = groupRedcordIdentity;
                    groups.Add(group);
                }

            }
            ScenarioContext.Current.AddNewRemoveExisting("groupIds", groupIds);
            ScenarioContext.Current.AddNewRemoveExisting("groups", groups);
        }

        [Given(@"the Customer Groups are linked to the following respective Locations")]
        public void GivenTheCustomerGroupsAreLinkedToTheFollowingRespectiveLocations(Table table)
        {
            var now = DateTime.Now;
            var groups = ScenarioContext.Current.Get<List<Group>>("groups");
            var locations = ScenarioContext.Current.Get<List<Location>>("locations");
            var groupLocationsOps = new GroupLocationsOperations();
            foreach (var tableRow in table.Rows)
            {
                var currentGroup = groups.Single(g => g.Name == tableRow["GroupName"]);
                var currentLocation = locations.Single(l => l.Name == tableRow["LocationName"]);
                var groupLocation = new GroupLocations()
                {
                    GroupId = currentGroup.GroupId,
                    LocationId = currentLocation.LocationId,
                    CreatedByExternalId = "admin",
                    UpdatedByExternalId = "admin",
                    DateCreatedUtc = now,
                    DateUpdatedUtc = now
                };
                groupLocationsOps.SaveAsNewGroupLocation(groupLocation, _cnn);
            }
        }

        [Given(@"the customer has the follwing menus")]
        public void GivenTheCustomerHasTheFollwingMenus(Table table)
        {

            var customer = ScenarioContext.Current.Get<Customer>("customer");
            var now = DateTime.Now;
            var menuIds = new List<int>();
            var menus = new List<Menu>();

            foreach (var tableRow in table.Rows)
            {
                var menu = new Menu(customer)
                {
                    Name = tableRow["MenuName"]
                };

                var menuOps = new MenuOperations();
                if (!menuOps.MenuExistsInDb(menu, _cnn))
                {
                    menu.ExternalId = Guid.NewGuid();
                    menu.CreatedByExternalId = "admin";
                    menu.UpdatedByExternalId = "admin";
                    menu.DateCreatedUtc = now;
                    menu.DateUpdatedUtc = now;
                    menu.MenuType = 1;
                    int menuRecordIdentity;
                    menuOps.SaveAsNewMenu(menu, _cnn, out menuRecordIdentity);
                    menuIds.Add(menuRecordIdentity);
                    menu.MenuId = menuRecordIdentity;
                    menus.Add(menu);

                }
            }
            ScenarioContext.Current.AddNewRemoveExisting("menuIds", menuIds);
            ScenarioContext.Current.AddNewRemoveExisting("menus", menus);
        }

        [Given(@"the customer menus are linked to the following recipes")]
        public void GivenTheCustomerMenusAreLinkedToTheFollowingRecipes(Table table)
        {

            var customer = ScenarioContext.Current.Get<Customer>("customer");
            var now = DateTime.Now;
            var recipeIds = new List<int>();
            var recipes = new List<Recipe>();

            foreach (var tableRow in table.Rows)
            {
                var recipe = new Recipe(customer)
                {
                    Name = tableRow["RecipeName"]
                };

                var recipeOps = new RecipeOperations();
                if (!recipeOps.RecipeExistsInDb(recipe, _cnn))
                {
                    recipe.ExternalId = Guid.NewGuid();
                    recipe.CreatedByExternalId = "admin";
                    recipe.UpdatedByExternalId = "admin";
                    recipe.DateCreatedUtc = now;
                    recipe.DateUpdatedUtc = now;
                    recipe.Cost = Convert.ToDecimal(Helpers.RandomNumberBetween(1.41, 3.14));
                    recipe.CostQuantity = Helpers.RandomNumberBetween(1, 5);
                    recipe.CostUnitOfMeasure = "myC";
                    recipe.MaximumCost = Convert.ToDecimal(Helpers.RandomNumberBetween(50.41, 80.14));
                    recipe.MinimumCost = Convert.ToDecimal(Helpers.RandomNumberBetween(10.41, 40.14));
                    recipe.SellPriceModel = Helpers.RandomNumberBetween(1, 5);
                    recipe.SellPriceModelValue = Convert.ToDecimal(Helpers.RandomNumberBetween(1.00, 10.00));
                    int recipeRedcordIdentity;
                    recipeOps.SaveAsNewRecipe(recipe, _cnn, out recipeRedcordIdentity);
                    recipeIds.Add(recipeRedcordIdentity);
                    recipe.RecipeId = recipeRedcordIdentity;
                    recipes.Add(recipe);
                }
            }
            ScenarioContext.Current.AddNewRemoveExisting("recipeIds", recipeIds);
            ScenarioContext.Current.AddNewRemoveExisting("recipes", recipes);
        }


        [Given(@"the customer recipes are linked to the following respective Menus")]
        public void GivenTheCustomerRecipesAreLinkedToTheFollowingRespectiveMenus(Table table)
        {
            var now = DateTime.Now;
            var menus = ScenarioContext.Current.Get<List<Menu>>("menus");
            var recipes = ScenarioContext.Current.Get<List<Recipe>>("recipes");
            var menuRecipeOps = new MenuRecipeOperations();

            foreach (var tabelRow in table.Rows)
            {
                var currentMenu = menus.Single(m => m.Name == tabelRow["MenuName"]);
                var currentRecipe = recipes.Single(r => r.Name == tabelRow["RecipeName"]);

                var menuRecipe = new MenuRecipes();
                {
                    menuRecipe.MenuId = currentMenu.MenuId;
                    menuRecipe.RecipeId = currentRecipe.RecipeId;
                    menuRecipe.CreatedByExternalId = "admin";
                    menuRecipe.UpdatedByExternalId = "admin";
                    menuRecipe.DateCreatedUtc = now;
                    menuRecipe.DateUpdatedUtc = now;
                    menuRecipe.Course = "MyCourse";
                };
                menuRecipeOps.SaveAsNewMenuRecipe(menuRecipe, _cnn);
            }
        }

        [Given(@"the customer menus are linked to the following Groups")]
        public void GivenTheCustomerMenusAreLinkedToTheFollowingGroups(Table table)
        {
            var now = DateTime.Now;
            var groups = ScenarioContext.Current.Get<List<Group>>("groups");
            var menus = ScenarioContext.Current.Get<List<Menu>>("menus");
            var groupMenusOps = new GroupMenusOperations();
            foreach (var tableRow in table.Rows)
            {
                var currentGroup = groups.Single(g => g.Name == tableRow["GroupName"]);
                var currentMenu = menus.Single(l => l.Name == tableRow["MenuName"]);
                var groupMenu = new GroupMenus()
                {
                    GroupId = currentGroup.GroupId,
                    MenuId = currentMenu.MenuId,
                    CreatedByExternalId = "admin",
                    UpdatedByExternalId = "admin",
                    DateCreatedUtc = now,
                    DateUpdatedUtc = now
                };
                groupMenusOps.SaveAsNewGroupMenus(groupMenu, _cnn);
            }

        }
        [Given(@"the customer recipes are linked to the following Groups")]
        public void GivenTheCustomerRecipesAreLinkedToTheFollowingGroups(Table table)
        {
            var now = DateTime.Now;
            var groups = ScenarioContext.Current.Get<List<Group>>("groups");
            var recipes = ScenarioContext.Current.Get<List<Recipe>>("recipes");
            var groupMenusOps = new GroupRecipesOperations();
            foreach (var tableRow in table.Rows)
            {
                var currentGroup = groups.Single(g => g.Name == tableRow["GroupName"]);
                var currentRecipe = recipes.Single(r => r.Name == tableRow["RecipeName"]);
                var groupRecipe = new GroupRecipes()
                {
                    GroupId = currentGroup.GroupId,
                    RecipeId = currentRecipe.RecipeId,
                    CreatedByExternalId = "admin",
                    UpdatedByExternalId = "admin",
                    DateCreatedUtc = now,
                    DateUpdatedUtc = now
                };
                groupMenusOps.SaveAsNewGroupRecipes(groupRecipe, _cnn);
            }
        }



        [Given(@"the user '(.*)' with customerId (.*) exists")]
        public void GivenTheUserWithCustomerIdExists(string userName, int customerId)
        {
            var customer = GetCustomer(customerId);
            var groups = GetGroups(customerId);

            if (customer != null)
            {
                ScenarioContext.Current.AddNewRemoveExisting("customer", customer);
                var now = DateTime.Now;
                var user = new User(customer, groups)
                {
                    Name = userName,
                };

                var userOps = new UserOperations();
                if (!userOps.UserExistsInDb(user, _cnn))
                {
                    user.ExternalId = userName;
                    user.CreatedByExternalId = "admin";
                    user.UpdatedByExternalId = "admin";
                    user.IsCentral = "1";
                    user.DateCreatedUtc = now;
                    user.DateUpdatedUtc = now;
                    int userRedcordIdentity;
                    userOps.SaveAsNewUser(user, _cnn, out userRedcordIdentity);
                    ScenarioContext.Current.AddNewRemoveExisting("userRedcordIdentity", userRedcordIdentity);
                    user.UserId = userRedcordIdentity;
                    ScenarioContext.Current.AddNewRemoveExisting("user", user);

                }
            }
            else
            {
                throw new Exception("Customer is not Created");
            }

        }

        private Customer GetCustomer(int customerId)
        {
            var customerOps = new CustomerOperations();
            if (customerOps.CustomerExistsInDbById(customerId, _cnn))
            {
                var customer = customerOps.FindCustomerById(customerId, _cnn);
                return customer;
            }
            return null;
        }

        private List<Group> GetGroups(int customerId)
        {
            var customerOps = new CustomerOperations();
            if (customerOps.CustomerExistsInDbById(customerId, _cnn))
            {
                var groups = customerOps.FindGroups(customerId, _cnn);

                return groups;
            }
            return null;
        }


        [Given(@"the customer '(.*)' has follwing mealperiods")]
        public void GivenTheCustomerHasFollwingMealperiods(int customerId, Table table)
        {

            var customer = GetCustomer(customerId);

            var now = DateTime.Now;
            var mealperiodIds = new List<int>();
            var mealPeriods = new List<MealPeriod>();

            foreach (var tableRow in table.Rows)
            {
                var mealPeriod = new MealPeriod(customer)
                {
                    Name = tableRow["MealPeriodName"]
                };

                var mealPeriodOps = new MealPeriodOperations();


                if (!mealPeriodOps.MealPeriodsExistsInDb(mealPeriod, _cnn))
                {
                    mealPeriod.ExternalId = Guid.NewGuid();
                    mealPeriod.CreatedByExternalId = "admin";
                    mealPeriod.UpdatedByExternalId = "admin";
                    mealPeriod.DateCreatedUtc = now;
                    mealPeriod.DateUpdatedUtc = now;  
               
                    int mealPeriodRecordIdentity;
                    mealPeriodOps.SaveAsNewMenu(mealPeriod, _cnn, out mealPeriodRecordIdentity);
                    mealperiodIds.Add(mealPeriodRecordIdentity);
                    mealPeriod.MealPeriodId = mealPeriodRecordIdentity;
                    mealPeriods.Add(mealPeriod);

                }
            }
            ScenarioContext.Current.AddNewRemoveExisting("mealperiodIds", mealperiodIds);
            ScenarioContext.Current.AddNewRemoveExisting("mealPeriods", mealPeriods);

        }
    
        [Given(@"the customer '(.*)' has follwing tariffs")]
        public void GivenTheCustomerHasFollwingTariffs(int customerId, Table table)
        {

            var customer = GetCustomer(customerId);
            var now = DateTime.Now;
            var tariffsIds = new List<int>();
            var tariffs = new List<Tariffs>();

            foreach (var tableRow in table.Rows)
            {
                var tariff = new Tariffs(customer)
                {
                    Name = tableRow["TariffName"]
                };

                var tariffOps = new TariffOperations();
                if (!tariffOps.TariffExistsInDb(tariff, _cnn))
                {  
                    tariff.CreatedByExternalId = "admin";
                    tariff.UpdatedByExternalId = "admin";
                    tariff.DateCreatedUtc = now;
                    tariff.DateUpdatedUtc = now;
                    tariff.description = "AutomatioTariffs";
                    int tariffRecordIdentity;
                    tariffOps.SaveAsNewTariff(tariff, _cnn, out tariffRecordIdentity);
                    tariffsIds.Add(tariffRecordIdentity);
                    tariff.TariffId = tariffRecordIdentity;
                    tariffs.Add(tariff);

                }
            }
            ScenarioContext.Current.AddNewRemoveExisting("tariffsIds", tariffsIds);
            ScenarioContext.Current.AddNewRemoveExisting("tariffs", tariffs);
        }






    }

}
