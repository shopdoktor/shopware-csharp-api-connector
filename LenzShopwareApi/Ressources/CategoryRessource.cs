using RestSharp;
using System;
using Lenz.ShopwareApi.Models.Categories;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lenz.ShopwareApi.Ressources
{
    public class CategoryRessource : SuperRessource<Category>, ICategoryRessource
    {
        public CategoryRessource(IRestClient client)
            : base (client)
        {
            ressourceUrl = "categories";
        }

        public new List<Category> getAll()
        {
            ApiRequest request = new ApiRequest(this.ressourceUrl, Method.GET);
            ApiRequestExecutor executor = new ApiRequestExecutor();

            ApiResponse<List<Category>> response = executor.execute<List<Category>>(client, request);

            Debug.WriteLine("New Method used!");

            return response.data;
        }

        public new void add(Category category)
        {
            if(category.name != null) {
                    base.add(category);
                return;
            }
            throw new Exception("Minimum required fields for category add: category.name");
        }


        new public void update(Category category)
        {
            if(category.id != null && category.name != null)
            {
                base.executeUpdate(category, category.id.ToString());
                return;
            }
            throw new Exception("Minimum required fields for article update: category.id, category.name");
        }

        public void delete(int id)
        {
            base.delete(id.ToString());
        }
    }
}
