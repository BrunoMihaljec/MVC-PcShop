using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_PcShop.DAL;
using MVC_PcShop.Models;

namespace MVC_PcShop.Controllers
{
    public class PcComponentController : Controller
    {
        private PcShopContext db = new PcShopContext();

        // GET: PcComponent
        public ActionResult Index()
        {
            var pcComponents = db.PcComponents.Include(p => p.Category);
            return View(pcComponents.ToList());
        }


        // GET: PcComponent/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PcComponent pcComponent = db.PcComponents.Find(id);
            if (pcComponent == null)
            {
                return HttpNotFound();
            }
            return View(pcComponent);
        }

        // GET: PcComponent/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "CategoryName");
            return View();
        }

        // POST: PcComponent/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Type,Name,Manufacturer,Price,CategoryID")] PcComponent pcComponent)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.PcComponents.Add(pcComponent);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch(DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "CategoryName", pcComponent.CategoryID);
            return View(pcComponent);
        }

        // GET: PcComponent/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PcComponent pcComponent = db.PcComponents.Find(id);
            if (pcComponent == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "CategoryName", pcComponent.CategoryID);
            return View(pcComponent);
        }

        // POST: PcComponent/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Type,Name,Manufacturer,Price,CategoryID")] PcComponent pcComponent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pcComponent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "CategoryName", pcComponent.CategoryID);
            return View(pcComponent);
        }

        // GET: PcComponent/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            PcComponent pcComponent = db.PcComponents.Find(id);
            if (pcComponent == null)
            {
                return HttpNotFound();
            }
            return View(pcComponent);
        }

        // POST: PcComponent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PcComponent pcComponent = db.PcComponents.Find(id);
            db.PcComponents.Remove(pcComponent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
