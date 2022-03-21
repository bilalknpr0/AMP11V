using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sınavdeneme.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("storeDb")
        {
            Database.SetInitializer(new StoreInitiliazer());
        }

        public DbSet<Flower> t_flower { get; set; }
        public DbSet<Category> t_category { get; set; }

    }
}