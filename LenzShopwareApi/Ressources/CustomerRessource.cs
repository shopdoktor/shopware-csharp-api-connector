using Lenz.ShopwareApi.Models.Orders;
using RestSharp;

namespace Lenz.ShopwareApi.Ressources
{
    public class CustomerRessource : SuperRessource<Order>
    {
        public CustomerRessource(IRestClient client)
            : base (client)
        {
            ressourceUrl = "customers";
        }
    }
}
