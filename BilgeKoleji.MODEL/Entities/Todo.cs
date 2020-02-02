using BilgeKoleji.CORE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MODEL.Entities
{
   public class Todo:CoreEntity
    {
        [Required(ErrorMessage ="Görev detayı girilmellisiniz.")]
        public string TaskContent { get; set; }
        public bool IsComplete{ get; set; }
        public DateTime? EndDate { get; set; }
        public Guid RegisterId { get; set; }

        public virtual Register Register { get; set; }

    }
}
