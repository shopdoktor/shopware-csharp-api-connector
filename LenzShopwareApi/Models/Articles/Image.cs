using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenz.ShopwareApi.Models.Articles
{
    public class Image
    {
        public int id;
        public int articleId;
        public int? articleDetailId;
        public String description;
        public String path;
        public int main;
        public int position;
        public int width;
        public int height;
        public String relations;
        public String extension;
        public int? parentId;
        public int mediaId;
    }
}
