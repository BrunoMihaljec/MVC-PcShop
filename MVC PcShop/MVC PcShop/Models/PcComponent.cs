using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_PcShop.Models
{
    public class PcComponent
    {
        
        public int ID { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }
       
        public double Price { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}