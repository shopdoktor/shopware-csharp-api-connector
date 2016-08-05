using RestSharp;
using System;
using Lenz.ShopwareApi.Models.Categories;

namespace Lenz.ShopwareApi.Ressources
{
    public class CategoryRessource : SuperRessource<Category>, ICategoryRessource
    {
        public CategoryRessource(IRestClient client)
            : base (client)
        {
            ressourceUrl = "categories";
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
