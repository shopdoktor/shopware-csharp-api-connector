using Lenz.ShopwareApi.Models.Articles;
using RestSharp;
using System;

namespace Lenz.ShopwareApi.Ressources
{
    public class ArticleRessource : SuperRessource<ArticleMain>, IArticleRessource
    {
        public ArticleRessource(IRestClient client)
            : base (client)
        {
            ressourceUrl = "articles";
        }

        public new void add(ArticleMain article)
        {
            if(article.name != null
                && article.mainDetail.number != null
                && article.supplier != null
                && article.tax.tax != null) {
                    base.add(article);
                return;
            }
            throw new Exception("Minimum required fields for article add: article.name, article.mainDetail.number, article.supplier.name, article.tax.tax");
        }

        new public void update(ArticleMain article)
        {
            if(article.id != null)
            {
                if(article.mainDetail.configuratorOptions.Count == 0)
                {
                    article.mainDetail.configuratorOptions = null;
                }
                base.executeUpdate(article, article.id.ToString());
                return;
            }
            throw new Exception("Minimum required fields for article update: article.id, article.name, article.mainDetail.number, article.supplier.name, article.tax.tax");
        }

        /// <summary>
        /// With this function it is possible to request an article by ordernumber
        /// </summary>
        /// <param name="ordernumber"></param>
        /// <returns></returns>
        public ArticleMain getByOrdernumber(string ordernumber)
        {
            return this.get(ordernumber + "?useNumberAsID=true");
        }
    }
}
