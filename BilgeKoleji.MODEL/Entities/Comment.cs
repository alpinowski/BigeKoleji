using BilgeKoleji.CORE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MODEL.Entities
{
    public class Comment:CoreEntity
    {
        [Display(Name="Başlık")]
        public string Header { get; set; }
        [Display(Name ="Yazı")]
        public string Text { get; set; }
        public bool IsActive { get; set; }
        public virtual Article Article { get; set; }
        public virtual Register Register { get; set; }
    }
}
