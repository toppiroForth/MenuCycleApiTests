using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using MenuCycleApiTests_ci.Domain.Models;
using MenuCycleApiTests_ci.Domain.Siren;
using TechTalk.SpecFlow.Assist;
using MenuCycleApiTests_ci.Domain.Model;
using MenuCycleApiTests_ci.GlobalData;
namespace MenuCycleApiTests_ci.Menus.Steps
{

    [Binding]
    public class GETMenusStepDef
    {

        private readonly MenuCycleRecord menuCycleRecord;

        public GETMenusStepDef(MenuCycleRecord menuCycleRecord)
        {
            this.menuCycleRecord = menuCycleRecord;
        }

        [Then(@"the following Menus propertie collection is returned by the server")]
        public void ThenTheFollowingMenusPropertieCollectionIsReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var Menus = JsonConvert.DeserializeObject<PagedCollectionEntity<MenusItemEntity<MenusItemsProperties>>>(response.Content);
            table.CompareToSet<MenusItemsProperties>(Menus.entities.Select(x => x.properties));
        }

        [Then(@"the following Menu entities are class '(.*)' and rel '(.*)'are returned")]
        public void ThenTheFollowingMenuEntitiesAreClassAndRelAreReturned(string Class, string rel)
        {

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embeddedLink = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);

            foreach (var entity in embeddedLink.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();

                if ((cls == Class) && (Rel == rel))
                {
                    continue;
                }
                else
                {
                    throw new Exception("Items links Mealperiods and rels are not Found!");
                }
            }
        }


        [Then(@"the following menu propertie are returned by the server")]
        public void ThenTheFollowingMenuPropertieAreReturnedByTheServer(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var menu = JsonConvert.DeserializeObject<MenusItemEntity<MenusItemsProperties>>(response.Content);
            table.CompareToInstance<MenusItemsProperties>(menu.properties);
        }

        [Then(@"the following Menusentites entities are returned")]
        public void ThenTheFollowingMenusentitesEntitiesAreReturned(Table table)
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embadedLinks = JsonConvert.DeserializeObject<PagedCollectionEntity<EmbeddedLink>>(response.Content);

            foreach (var entity in embadedLinks.entities)
            {
                var cls = entity.Class.First();
                var Rel = entity.rel.First();
                var valid = table.Rows.Any(x => x["Class"] == cls && x["rel"] == Rel);

                if (!valid)
                {
                    throw new Exception("Items Menu entities class  and rels are not Found!");
                }
            }
        }

        [Then(@"user should get the last menuId from response")]
        public void ThenUserShouldGetTheLastMenuIdFromResponse()
        {
            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var Menus = JsonConvert.DeserializeObject<PagedCollectionEntity<MenusItemEntity<MenusItemsProperties>>>(response.Content);

            foreach (var menu in Menus.entities)
            {
                menuCycleRecord.idList.Add(menu.properties.menuId);
                Console.WriteLine("the menulist are", menu.properties.menuId);
            }
            Console.WriteLine("the last menu id ", menuCycleRecord._menuId = menuCycleRecord.idList.Last());
        }

        [Then(@"the follwing links are returned")]
        public void ThenTheFollwingLinksAreReturned(Table table)
        {
            int id = menuCycleRecord._menuId;

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embadedLinks = JsonConvert.DeserializeObject<MenusItemEntity<EmbeddedLink>>(response.Content);
            //var rows = table.Rows.Where(x => x.ContainsKey("href"));
            foreach (var row in table.Rows)
            {
                var item = row.FirstOrDefault(x => x.Key == "href").Value;
                if (!string.IsNullOrEmpty(item))
                {
                    menuCycleRecord.Menuentiteherf.Add(string.Format(item, id));
                }
            }

            var result = Enumerable.SequenceEqual(
                embadedLinks.links.Select(y => y.href).ToList().OrderBy(x => x),
                menuCycleRecord.Menuentiteherf.OrderBy(m => m));

        

        }


        [Then(@"the following '(.*)' links returned for single menu")]
        public void ThenTheFollowingLinksReturnedForSingleMenu(string links, Table table)
        {

            int id = menuCycleRecord._menuId;

            var response = ScenarioContext.Current.Get<RestResponse>("Response");
            var embadedLinks = JsonConvert.DeserializeObject<MenusItemEntity<EmbeddedLink>>(response.Content);
            //var rows = table.Rows.Where(x => x.ContainsKey("href"));
            foreach (var row in table.Rows)
            {
                var item = row.FirstOrDefault(x => x.Key == "href").Value;
                if (!string.IsNullOrEmpty(item))
                {
                    menuCycleRecord.href.Add(string.Format(item, id));
                }
            }

            var result = Enumerable.SequenceEqual(
                embadedLinks.entities.Select(y => y.href.ToString()).ToList().OrderBy(x => x),
                menuCycleRecord.href.OrderBy(m => m));

        }












    }
}
