using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodFinderDB
{
    class FoodFinderContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<Supermarket> Supermarkets { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<History> Histories { get; set; }
        //public DbSet<RelationProductStore> RelationProductStores { get; set; }

    }
}
