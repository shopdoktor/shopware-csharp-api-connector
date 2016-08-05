using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenz.ShopwareApi.Models.Categories
{
    public class Category
    {
        public int id;
        public int parentId;
        public int streamId;
        public string name;
        public int position;
        public string metaTitle;
        public string metaDescription;
        public string cmsHeadline;
        public string cmsText;
        public bool active;
        public string template;
        public string productBoxLayout;
        public bool blog;
        public string path;
        public bool showFilterGroups;
        public bool external;
        public bool hideFilter;
        public bool hideTop;
        public string changed;
        public string added;
        public int mediaId;
        public string attribute;
        //public string emotions;
        public string media;
        //public List<string> customerGroups;
        public int childrenCount;
        public int articleCount;
    }
}
