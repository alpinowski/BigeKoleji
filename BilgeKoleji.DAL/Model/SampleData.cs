using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BilgeKoleji.DAL.Model.Context;

namespace BilgeKoleji.DAL.Model
{
    public class SampleData:CreateDatabaseIfNotExists<KolejContext>
    {
        
    }
}
