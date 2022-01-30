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
    public class Product_NumberController : Controller
    {
        private SAMYEntities db = new SAMYEntities();

        // GET: Product_Number
        public ActionResult Index()
        {
            var product_Number = db.Product_Number.Include(p => p.Client_Products).Include(p => p.Product_Quality).Include(p => p.Product_Status);
            return View(product_Number.ToList());
        }

        // GET: Product_Number/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Number product_Number = db.Product_Number.Find(id);
            if (product_Number == null)
            {
                return HttpNotFound();
            }
            return View(product_Number);
        }

        // GET: Product_Number/Create
        public ActionResult Create()
        {
            ViewBag.Client_Product_ID = new SelectList(db.Client_Products, "ID", "Location");
            ViewBag.Quality_ID = new SelectList(db.Product_Quality, "ID", "QualityName");
            ViewBag.Product_Status_ID = new SelectList(db.Product_Status, "ID", "Name");
            return View();
        }

        // POST: Product_Number/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Client_Product_ID,Quality_ID,Product_Status_ID,ProductNumber,TransferDate,IsLocked,LockedReason,LockedBy,MES_RefID")] Product_Number product_Number)
        {
            if (ModelState.IsValid)
            {
                db.Product_Number.Add(product_Number);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Client_Product_ID = new SelectList(db.Client_Products, "ID", "Location", product_Number.Client_Product_ID);
            ViewBag.Quality_ID = new SelectList(db.Product_Quality, "ID", "QualityName", product_Number.Quality_ID);
            ViewBag.Product_Status_ID = new SelectList(db.Product_Status, "ID", "Name", product_Number.Product_Status_ID);
            return View(product_Number);
        }

        // GET: Product_Number/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Number product_Number = db.Product_Number.Find(id);
            if (product_Number == null)
            {
                return HttpNotFound();
            }
            ViewBag.Client_Product_ID = new SelectList(db.Client_Products, "ID", "Location", product_Number.Client_Product_ID);
            ViewBag.Quality_ID = new SelectList(db.Product_Quality, "ID", "QualityName", product_Number.Quality_ID);
            ViewBag.Product_Status_ID = new SelectList(db.Product_Status, "ID", "Name", product_Number.Product_Status_ID);
            return View(product_Number);
        }

        // POST: Product_Number/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Client_Product_ID,Quality_ID,Product_Status_ID,ProductNumber,TransferDate,IsLocked,LockedReason,LockedBy,MES_RefID")] Product_Number product_Number)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_Number).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Client_Product_ID = new SelectList(db.Client_Products, "ID", "Location", product_Number.Client_Product_ID);
            ViewBag.Quality_ID = new SelectList(db.Product_Quality, "ID", "QualityName", product_Number.Quality_ID);
            ViewBag.Product_Status_ID = new SelectList(db.Product_Status, "ID", "Name", product_Number.Product_Status_ID);
            return View(product_Number);
        }

        // GET: Product_Number/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Number product_Number = db.Product_Number.Find(id);
            if (product_Number == null)
            {
                return HttpNotFound();
            }
            return View(product_Number);
        }

        // POST: Product_Number/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Product_Number product_Number = db.Product_Number.Find(id);
            db.Product_Number.Remove(product_Number);
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
