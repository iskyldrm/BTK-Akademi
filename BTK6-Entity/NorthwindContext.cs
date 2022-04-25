using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK6_Entity
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Shipper> Shippers { get; set; }
    }
}
