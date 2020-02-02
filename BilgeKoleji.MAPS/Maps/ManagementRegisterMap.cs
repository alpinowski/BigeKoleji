using BilgeKoleji.CORE.Map;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MAPS.Maps
{
    public class ManagementRegisterMap : CoreMap<ManagementRegister>
    {
        public ManagementRegisterMap()
        {
            ToTable("dbo.ManagementRegister");
            Property(x => x.Name).IsRequired().HasColumnName("Ad");
            Property(x => x.Surname).IsRequired().HasColumnName("Soyad");
            Property(x => x.Password).IsRequired().HasColumnName("Parola");
            Property(x => x.ConfirmPassword).IsRequired().HasColumnName("Parola Doğrulama");
            Property(x => x.Email).IsRequired().HasColumnName("E-Posta");
            Property(x => x.Address).IsRequired().HasMaxLength(300).HasColumnName("Adres");
            Property(x => x.PhoneNumber).IsRequired().HasColumnName("Telefon Numarası");
            Property(x => x.Branch).IsRequired().HasColumnName("Branş");

        }
    }
}
