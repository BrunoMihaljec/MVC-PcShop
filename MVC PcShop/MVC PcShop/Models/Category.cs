using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_PcShop.Models
{   

    public class Category
    {
        
        public int ID { get; set; }

        public string Name { get; set; }

       public virtual ICollection<PcComponent> PcComponents { get; set; }
    }
}