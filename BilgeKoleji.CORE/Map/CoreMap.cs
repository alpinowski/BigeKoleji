using BilgeKoleji.CORE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.CORE.Map
{
     public class CoreMap<T>:EntityTypeConfiguration<T> where T:CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.CreatedDate).HasColumnName("CreatedDate");
        }
    }
}
