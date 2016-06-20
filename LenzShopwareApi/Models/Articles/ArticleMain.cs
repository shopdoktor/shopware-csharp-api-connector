using Lenz.ShopwareApi.Models.Suppliers;
using Lenz.ShopwareApi.Models.Taxes;
using System;
using System.Collections.Generic;

namespace Lenz.ShopwareApi.Models.Articles
{
    public class ArticleMain
    {
        public int? id;
        public int? mainDetailId;
        public int? taxId;
        public int? priceGroupId;
        public int? filterGroupId;
        public int? configuratorSetId;

        public string name;
        public string description;
        public string descriptionLong;



        public int pseudoSales;
        public bool notification;
        
        public bool active;
        public int pseudeSales;
        public bool highlight;
        public bool lastStock;
        public bool crossBundleLook;
        public string template;
        public int mode;
        public string availableFrom;
        public string availableTo;

        /* seo */
        public String keywords;
        public String metaTitle;
        /* history */
        public String added;
        public String changed;
        /* price */
        public bool priceGroupActive;


        public List<PropertyValue> propertyValues;

        public ArticleMainDetail mainDetail = new ArticleMainDetail();
        public Supplier supplier = new Supplier();
        public Tax tax = new Tax();

        public PropertyGroup propertyGroup;
        public List<CustomerGroup> customerGroups;
        public List<Image> images;


        public String configuratorSet;
        public List<Link> links;
        public List<Download> downloads;

        // public Category categories
        public List<ArticleDetail> details;
        public List<SeoCategory> seoCategories;
        public List<Category> categories;
        public List<SimilarArticle> similar;
        public List<RelatedArticle> related;
        public List<Translation> translations;
    }
}
