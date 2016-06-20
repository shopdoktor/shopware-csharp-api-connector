using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenz.ShopwareApi.Models.Articles
{
    public class Price
    {
        private int id;
        private int articleId;
        private int articleDetailsId;
        private String customerGroupKey;
        private float from;
        private String to;
        private float price;
        private float pseudoPrice;
        private float basePrice;
        private float percent;
    }
}
