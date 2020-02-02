using BilgeKoleji.CORE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MODEL.Entities
{
    public class Tag: CoreEntity
    {
        public string Text { get; set; }
        public virtual List<Article> Articles { get; set; }
    }
}
