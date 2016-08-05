using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lenz.ShopwareApi;
using Lenz.ShopwareApi.Models.Articles;
using Lenz.ShopwareApi.Models.Orders;
using System.Collections.Generic;

namespace ShopwareApiTests
{
    [TestClass]
    public class Articles
    {
        /*
        /*List<Order> orders = shopwareApi.getOrderRessource().getAll();

            foreach (Order order in orders)
            {
                Console.WriteLine("-- " + order.id + ": " + order.invoiceAmount);
            }*/

            /*Console.WriteLine("Artikel: " + article.name);
            Console.WriteLine("- ID: " + article.id);
            Console.WriteLine("- related articles:");
            foreach (RelatedArticle related in article.related)
            {
                Console.WriteLine("-- " + related.name);
            }
            
            article.name = article.name + " aktualisiert";
            shopwareApi.getArticleRessource().update(article);



            article = shopwareApi.getArticleRessource().get(1);

            Console.WriteLine("Artikel: " + article.name);
            Console.WriteLine("- ID: " + article.id);*/
        [TestMethod]
        public void getArticleById()
        {
            ShopwareApi shopwareApi = ApiConnection.getDemoApi();
            ArticleMain article = shopwareApi.getArticleRessource().get(1);

            Console.WriteLine("Artikel: " + article.name);
            Console.WriteLine("- ID: " + article.id);
        }

        [TestMethod]
        public void getAllArticles()
        {
            ShopwareApi shopwareApi = ApiConnection.getDemoApi();
            List<ArticleMain> articles = shopwareApi.getArticleRessource().getAll();

            Console.WriteLine("Found articles: " + articles.Count);
        }

        [TestMethod]
        public void getArticleByOrdernumber()
        {
            ShopwareApi shopwareApi = ApiConnection.getDemoApi();
            ArticleMain article = shopwareApi.getArticleRessource().getByOrdernumber("SW10151");

            Console.WriteLine("Artikel: " + article.name);
            Console.WriteLine("- ID: " + article.id);
        }
    }
}
