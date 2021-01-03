using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using MVC_PcShop.Models;

namespace MVC_PcShop.DAL
{
    public class PcShopContext : DbContext
    {
        public PcShopContext() : base("PcShopContext")
        {
        }
        public DbSet<PcComponent> Components { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}