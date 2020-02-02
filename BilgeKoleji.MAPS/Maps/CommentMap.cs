using BilgeKoleji.CORE.Map;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MAPS.Maps
{
    public class CommentMap:CoreMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comments");
            Property(x => x.Header).IsRequired();
            Property(x => x.Text).IsRequired();
        }
        
    }
}
