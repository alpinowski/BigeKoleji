using BilgeKoleji.CORE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MODEL.Entities
{
   public class Students:CoreEntity
    {
        public int Numara { get; set; }
        public int Sinif { get; set; }
        public string Sube { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Cinsiyet { get; set; }
        public string DevamDurumu { get; set; }
    }
}
