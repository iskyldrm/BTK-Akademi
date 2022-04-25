using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BTK6_Entity
{
    public class ShipperDal
    {
        public List<Shipper> GetAll() 
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Shippers.ToList<Shipper>();
            }
        }

        public void Add(Shipper shipper)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Shippers.Add(shipper);
                context.SaveChanges();
            }
        }

        public void Update(Shipper shipper)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var entity = context.Entry(shipper);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
