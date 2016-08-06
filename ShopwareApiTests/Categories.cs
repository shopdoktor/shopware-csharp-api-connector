using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using Lenz.ShopwareApi;
using Lenz.ShopwareApi.Models.Categories;

namespace ShopwareApiTests
{
    [TestClass]
    public class Categories
    {
        [TestMethod]
        public void getAll()
        {
            ShopwareApi shopwareApi = ApiConnection.getDemoApi();
            List<Category> categories = shopwareApi.getCategoryRessource().getAll();

            Debug.WriteLine("Found: " + categories.Count);

            int categoryID = 0;

            foreach(Category category in categories)
            {
                if(category.name == "Deutsch")
                {
                    categoryID = (int) category.id;
                }
            }

            Debug.WriteLine("CategoryID: " + categoryID);
        }

        [TestMethod]
        public void get()
        {
            ShopwareApi shopwareApi = ApiConnection.getDemoApi();
            try
            {
                Category category = shopwareApi.getCategoryRessource().get(5);
                Debug.WriteLine("Found category with name: " + category.name);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.StackTrace);
            }
        }


        [TestMethod]
        public void add()
        {
            ShopwareApi shopwareApi = ApiConnection.getDemoApi();

            Category category = new Category();
            category.name = "Test";
            category.parentId = 3;
            category.active = true;

            shopwareApi.getCategoryRessource().add(category);
        }

        [TestMethod]
        public void update()
        {
            ShopwareApi shopwareApi = ApiConnection.getDemoApi();

            Category category = shopwareApi.getCategoryRessource().get(8);
            category.name = "Kategorie 8";

            shopwareApi.getCategoryRessource().update(category);
        }

        [TestMethod]
        public void delete()
        {
            ShopwareApi shopwareApi = ApiConnection.getDemoApi();

            shopwareApi.getCategoryRessource().delete(6);
        }

    }
}
