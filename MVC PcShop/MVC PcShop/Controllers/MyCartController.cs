using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_PcShop.Models;
using MVC_PcShop.DAL;
using MVC_PcShop.Controllers;
using PagedList;

namespace MVC_PcShop.Controllers
{
    public class MyCartController : Controller
    {
        private PcShopContext db = new PcShopContext();

        // GET: MyCart
        public ActionResult Index()
        {
          
            return View();
        }

        public ActionResult Remove(int id)
        {
            
            IList<CartItem> Items = (List<CartItem>)Session["cart"];
                      
            Items.Remove(Items.Where(x => x.PcComponent.ID == id).FirstOrDefault());

            Session["cart"] = Items;
            return RedirectToAction("Index");
        }
        public ActionResult Buy(int id)
        {
            if (Session["cart"] == null)
            {
                List<CartItem> Items = new List<CartItem>();
                
                PcComponent cartitem = db.PcComponents.Find(id);               
                Items.Add(new CartItem { PcComponent = cartitem, Quantity = 1 });
                Session["cart"] = Items;
            }
            else
            {
                List<CartItem> Items = (List<CartItem>)Session["cart"];
                
                int index = isExist(id);
                if (index != -1)
                {
                    Items[index].Quantity++;
                }
                else
                {
                    PcComponent cartitem = db.PcComponents.Find(id);
                    Items.Add(new CartItem { PcComponent = cartitem, Quantity = 1 });
                } 
                Session["cart"] = Items;
            }

            return RedirectToAction("Index", "PcComponent");
        }

        private int isExist(int id)
        {
            List<CartItem> Items = (List<CartItem>)Session["cart"];
            for (int i = 0; i < Items.Count; i++)
                if (Items[i].PcComponent.ID.Equals(id))
                    return i;
            return -1;
        }

        public ActionResult IncreaseQuantity(int id)
        {
            List<CartItem> Items = (List<CartItem>)Session["cart"];

            int index = isExist(id);
            if (index != -1)
            {
                Items[index].Quantity++;
            }
            else
            {
                PcComponent cartitem = db.PcComponents.Find(id);
                Items.Add(new CartItem { PcComponent = cartitem, Quantity = 1 });
            }
            Session["cart"] = Items;
            return RedirectToAction("Index");
        }

        public ActionResult DecreaseQuantity(int id)
        {
            IList<CartItem> Items = (List<CartItem>)Session["cart"];

            int index = isExist(id);
            if (index != -1)
            {
                Items[index].Quantity--;
            }

            Items.Remove(Items.Where(x => x.Quantity == 0).FirstOrDefault());

            Session["cart"] = Items;
            return RedirectToAction("Index");
        }
      
    }
}