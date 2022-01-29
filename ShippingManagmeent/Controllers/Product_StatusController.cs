using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShippingManagmeent;

namespace ShippingManagmeent.Controllers
{
    public class Product_StatusController : Controller
    {
        private SAMYEntities db = new SAMYEntities();

        // GET: Product_Status
        public ActionResult Index()
        {
            return View(db.Product_Status.ToList());
        }

        // GET: Product_Status/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Status product_Status = db.Product_Status.Find(id);
            if (product_Status == null)
            {
                return HttpNotFound();
            }
            return View(product_Status);
        }

        // GET: Product_Status/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product_Status/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Location")] Product_Status product_Status)
        {
            if (ModelState.IsValid)
            {
                db.Product_Status.Add(product_Status);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product_Status);
        }

        // GET: Product_Status/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Status product_Status = db.Product_Status.Find(id);
            if (product_Status == null)
            {
                return HttpNotFound();
            }
            return View(product_Status);
        }

        // POST: Product_Status/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Location")] Product_Status product_Status)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_Status).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product_Status);
        }

        // GET: Product_Status/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Status product_Status = db.Product_Status.Find(id);
            if (product_Status == null)
            {
                return HttpNotFound();
            }
            return View(product_Status);
        }

        // POST: Product_Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product_Status product_Status = db.Product_Status.Find(id);
            db.Product_Status.Remove(product_Status);
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
