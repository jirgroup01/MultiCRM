using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCRM.BLL.EntityFramework
{
    public class MultiCRMDB:DbContext
    {
        public MultiCRMDB():base("name=MultiCRMConnectionString")
        {
            
        }
       public DbSet<Profiles> Profiles { get; set; }

    }
}
