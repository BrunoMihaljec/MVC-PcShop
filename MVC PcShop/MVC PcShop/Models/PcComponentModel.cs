using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PcShop.Models
{
    public class PcComponentModel
    {
        private List<PcComponent> ComponentList;

        public PcComponentModel()
        {
            ComponentList = new List<PcComponent>()
            {
               new PcComponent("1", "CPU", "AMD Ryzen 8 5800x", "AMD", 449.00),
               new PcComponent("2", "CPU", "Intel Core i7.10700k", "Intel", 412.64),
               new PcComponent("3", "CPU", "Intel Core i0-9900K", "Intel", 349.99),
               new PcComponent("4", "Memory", "G.Skill Trident", "G.skill", 174.99),
               new PcComponent("5", "Memory", "Team T-Force XTREEM ARGB", "Team", 154.60),
               new PcComponent("6", "Memory", "Corsair Vengeance LPX", "Corsair", 143.99),
               new PcComponent("7", "Motherboard", "Gigabyte X570 Aourus", "Gigabyte", 177.00),
               new PcComponent("8", "Motherboard", "Asus ROG MAXIMUS X11", "Asus", 513.66),
               new PcComponent("9", "Motherboard", "Gigabyte Z390 AORUS", "Gigabyte", 179.99),
               new PcComponent("10", "Storage", "Crucial MX500 1 TB", "Crucial", 170.59),
               new PcComponent("11", "Storage", "Samsung 970 Evo 1 TB", "Samsung", 129.99),
               new PcComponent("12", "Storage", "Western Digital SN750 1 TB", "Western Digital", 129.99),
               new PcComponent("13", "Video Card", "EVGA GeForce RTX 3080", "EVGA", 1000.00),
               new PcComponent("14", "Video Card", "PNY GeForce RTX 3090", "PNY", 1705.99),
               new PcComponent("15", "Video Card", "MSI GeForce RTX 3070", "MSI", 979.00),
            };
            
        }
        public List<PcComponent> findAll()
        {
            return ComponentList;
        }
        public PcComponent find(string id)
        {
            return ComponentList.Single(x => x.ID.Equals(id));
        }
    }
}