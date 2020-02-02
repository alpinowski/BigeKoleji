using BilgeKoleji.CORE.Map;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MAPS.Maps
{
    public class TeachersMap:CoreMap<Teachers>
    {
        public TeachersMap()
        {
            ToTable("dbo.Teachers");
            Property(x => x.Adi).IsRequired().HasColumnName("Adı");
            Property(x => x.Soyadi).IsRequired().HasColumnName("Soyadı");
            Property(x => x.Brans).IsRequired().HasColumnName("Branş");
            Property(x => x.Sira).IsRequired().HasColumnName("Sırası");
        }
    }
}
