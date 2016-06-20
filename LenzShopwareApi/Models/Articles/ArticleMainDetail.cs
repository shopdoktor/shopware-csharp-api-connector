using Lenz.ShopwareApi.Models.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenz.ShopwareApi.Models.Articles
{
    public class ArticleMainDetail
    {
        public int id;
        public int articleId;
        public int unitId;
        public string number;
        public string supplierNumber;
        public int kind;
        public string additionalText;
        public int active;
        public int inStock;
        public int stockMin;
        public string weight;
        public string width;
        public string len;
        public string height;
        public string ean;
        public int position;
        public int minPurchase;
        public int? purchaseSteps;
        public int? maxPurchase;
        public string purchaseUnit;
        public string referenceUnit;
        public string packUnit;
        public bool shippingFree;
        public string releaseDate;
        public string shippingTime;
        public List<Price> prices;
        public Lenz.ShopwareApi.Models.Articles.Attribute attribute;
        public List<ConfiguratorOption> configuratorOptions;
    }
}
