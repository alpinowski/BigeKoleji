using BilgeKoleji.CORE.Map;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MAPS.Maps
{
    public class StudentsMap : CoreMap<Students>
    {
        public StudentsMap()
        {
            ToTable("dbo.Students");
            Property(x => x.Adi).IsRequired().HasColumnName("Adı");
            Property(x => x.Soyadi).IsRequired().HasColumnName("Soyadı");
            Property(x => x.Cinsiyet).IsRequired().HasColumnName("Cinsiyet");
            Property(x => x.Numara).IsRequired().HasColumnName("Okul Numarası");
            Property(x => x.Sinif).IsRequired().HasColumnName("Sınıf");
            Property(x => x.Sube).IsRequired().HasColumnName("Şube");
            Property(x => x.DevamDurumu).IsRequired().HasColumnName("Devam Durumu");
        }
    }
}
