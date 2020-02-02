﻿using BilgeKoleji.CORE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji.MODEL.Entities
{
    public class Category:CoreEntity
    {
        public string CategoryName { get; set; }
        public virtual List<Article> Articles { get; set; }

    }
}
