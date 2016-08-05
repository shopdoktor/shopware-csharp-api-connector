using Lenz.ShopwareApi.Models.Categories;
using System.Collections.Generic;

namespace Lenz.ShopwareApi.Ressources
{
    public interface ICategoryRessource
    {
        List<Category> getAll();

        Category get(int id);

        Category get(string id);

        void add(Category category);

        void update(Category category);

        void delete(int id);
    }
}