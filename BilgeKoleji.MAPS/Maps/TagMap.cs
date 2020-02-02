using BilgeKoleji.CORE.Map;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MAPS.Maps
{
   public class TagMap:CoreMap<Tag>
    {
        public TagMap()
        {
            ToTable("dbo.Tags");
            Property(x => x.Text).IsRequired();
        }
    }
}
