using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.CORE.Entity.Enum
{
    public interface IEntity<T>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        T ID { get; set; }
    }
}
