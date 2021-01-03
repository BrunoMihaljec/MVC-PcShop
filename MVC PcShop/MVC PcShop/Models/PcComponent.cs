using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PcShop.Models
{
    public class PcComponent
    {
        public int ID;
        public string Type;
        public string Name;
        public string Manufacturer;
        public double Price;

        public virtual Category Category { get; set; }
    }
}