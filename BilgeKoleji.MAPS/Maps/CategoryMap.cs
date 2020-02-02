using BilgeKoleji.CORE.Map;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MAPS.Maps
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(x => x.CategoryName).IsRequired();
          
        }
    }
}
