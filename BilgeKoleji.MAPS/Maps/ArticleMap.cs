using BilgeKoleji.CORE.Map;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MAPS.Maps
{
   public class ArticleMap : CoreMap<Article>
    {
        public ArticleMap()
        {
            ToTable("dbo.Articles");
            Property(x => x.Header).IsRequired();
            Property(x => x.Description).IsRequired();
            Property(x => x.Content).IsRequired();
        }
    }
}
