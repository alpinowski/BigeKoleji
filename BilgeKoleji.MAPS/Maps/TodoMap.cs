using BilgeKoleji.CORE.Map;
using BilgeKoleji.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MAPS.Maps
{
    public class TodoMap:CoreMap<Todo>
    {
        public TodoMap()
        {
            ToTable("dbo.Todo");
            Property(x => x.TaskContent).IsRequired();
        }
    }
}
