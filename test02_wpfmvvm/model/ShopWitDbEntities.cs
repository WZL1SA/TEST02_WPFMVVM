using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace TEST02_WPFMVVM.model
{
    public class ShopWitDbEntities : DbContext
    {
        public ShopWitDbEntities()
            : base("ShopWitDbEntities")
        {
        }
       
        public DbSet<CustomerModel> Customers { get; set; }
    }
}
