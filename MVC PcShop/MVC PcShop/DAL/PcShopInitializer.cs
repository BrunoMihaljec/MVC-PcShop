using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_PcShop.Models;

namespace MVC_PcShop.DAL
{
    public class PcShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PcShopContext>
    {
        protected override void Seed(PcShopContext context)
        {
            var components = new List<PcComponent>
            {
            new PcComponent{Type = "CPU",Name = "AMD Ryzen 8 5800x",Manufacturer = "AMD",Price = 449.00 },
            new PcComponent{Type = "CPU",Name = "Intel Core i7.10700k",Manufacturer = "Intel",Price = 412.64},
            new PcComponent{Type = "CPU",Name = "Intel Core i0-9900K",Manufacturer = "Intel",Price = 349.99},
            new PcComponent{Type = "Memory",Name = "G.Skill Trident",Manufacturer = "G.skill",Price = 174.99},
            new PcComponent{Type = "Memory",Name = "Team T-Force XTREEM ARGB",Manufacturer = "Team",Price = 154.60},
            new PcComponent{Type = "Memory",Name = "Corsair Vengeance LPX",Manufacturer = "Corsair",Price = 143.99},
            new PcComponent{Type = "Motherboard",Name = "Gigabyte X570 Aourus", Manufacturer = "Gigabyte", Price = 177.00 },
            new PcComponent{Type = "Motherboard",Name = "Asus ROG MAXIMUS X11", Manufacturer = "Asus", Price = 513.66 },
            new PcComponent{Type = "Motherboard",Name = "Gigabyte Z390 AORUS",Manufacturer = "Gigabyte",Price = 179.99},
            new PcComponent{Type = "Storage",Name = "Crucial MX500 1 TB",Manufacturer = "Crucial",Price = 170.59},
            new PcComponent{Type = "Storage",Name = "Samsung 970 Evo 1 TB",Manufacturer ="Samsung",Price = 129.99},
            new PcComponent{Type = "Storage",Name = "Western Digital SN750 1 TB",Manufacturer ="Western Digital",Price = 129.99},
            new PcComponent{Type = "Video Card",Name = "EVGA GeForce RTX 3080",Manufacturer = "EVGA",Price = 1000.00},
            new PcComponent{Type = "Video Card",Name = "PNY GeForce RTX 3090",Manufacturer = "PNY",Price = 1705.99},
            new PcComponent{Type = "Video Card",Name = "MSI GeForce RTX 3070",Manufacturer = "MSI",Price = 979.00}
            };

            components.ForEach(c => context.Components.Add(c));
            context.SaveChanges();
            var categories = new List<Category>
            {
                new Category{Name = "CPU", ID = 1},
                new Category{Name = "Memory", ID = 2},
                new Category{Name = "MotherBoard", ID = 3},
                new Category{Name = "Storage", ID = 4},
                new Category{Name = "Video Card", ID = 5}
            };
            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();
        }
    }
}