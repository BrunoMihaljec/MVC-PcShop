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
        //If models change drop existing database and create a new one
        protected void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PcShopContext>());
        }

        public PcShopContext() : base("PcShopContext")
        {
        }
        
        public DbSet<PcComponent> PcComponents { get; set; }
        public DbSet<Category> Categories { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}