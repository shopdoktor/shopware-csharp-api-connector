using Lenz.ShopwareApi.Models.Orders;
using System.Collections.Generic;

namespace Lenz.ShopwareApi.Ressources
{
    public interface IOrderRessource
    {
        /**
            Get all orders (with less information).

            // Example start.
            ShopwareApi shopwareApi = new ShopwareApi("API-URL", "USER", "API-KEY");
            List<Order> orders = shopwareApi.getOrderRessource().getAll();
            // Example end.
        */
        List<Order> getAll();

        /**
            Get an order by its id.

            // Example start.
            ShopwareApi shopwareApi = new ShopwareApi("API-URL", "USER", "API-KEY");
            Order order = shopwareApi.getOrderRessource().get(1);
            // Example end.
        */
        Order get(int id);

        /**
            Get an order by its number.

            // Example start.
            ShopwareApi shopwareApi = new ShopwareApi("API-URL", "USER", "API-KEY");
            Order order = shopwareApi.getOrderRessource().get("20003?useNumberAsId=true");
            // Example end.
        */
        Order get(string id);

        /**
            Update a single order. WARNING: Only the inserted values are updated. All other values remain with the original values.

            // Example start.
            ShopwareApi shopwareApi = new ShopwareApi("API-URL", "USER", "API-KEY");
            Order order = new Order();
            order.paymentStatusId = 1;
            shopwareApi.getOrderRessource().update(order);
            // Example end.
        */
        void update(Order order);
    }
}