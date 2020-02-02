using BilgeKoleji.CORE.Map;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MAPS.Maps
{
    public class UserMap:CoreMap<User>
    {
        public UserMap()
        {
            ToTable("dbo.Users");
            Property(x => x.UserName).IsRequired().HasMaxLength(30).HasColumnName("Kullanıcı Adı");
            Property(x => x.Password).IsRequired().HasMaxLength(30).HasColumnName("Parola");
            Property(x => x.OgrenciTCKimlikNumarasi).IsRequired().HasColumnName("TC Kimlik Numarası");
            Property(x => x.OkulNumarasi).IsRequired().HasColumnName("Okul Numarası");

        }
    }
}
