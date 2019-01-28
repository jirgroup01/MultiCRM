using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCRM.Common
{
    public class CProfile
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public CAuthentication CreateAuth { get; set; }

        public CAuthentication UpdateAuth { get; set; }


    }
}
