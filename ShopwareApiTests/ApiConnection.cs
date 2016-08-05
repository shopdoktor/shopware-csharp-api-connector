using Lenz.ShopwareApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApiTests
{
    class ApiConnection
    {
        public static ShopwareApi getDemoApi()
        {
            // URL, USERNAME, API-KEY
            ShopwareApi shopwareApi = new ShopwareApi("https://www.shopapi.de/api/", "shopdoktor", "IcDDc7diFMT1rhd3ZoDPHsB6eaAFEE10EqJk5gny");
            return shopwareApi;
        }
    }
}
