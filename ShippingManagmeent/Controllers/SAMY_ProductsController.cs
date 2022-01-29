using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShippingManagmeent;
using EntityState = System.Data.Entity.EntityState;

namespace ShippingManagmeent.Controllers
{
    public class SAMY_ProductsController : Controller
    {
        private SAMYEntities db = new SAMYEntities();

        // GET: SAMY_Products
        public ActionResult Index()
        {
            return View(db.SAMY_Products.ToList());
        }

        // GET: SAMY_Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SAMY_Products sAMY_Products = db.SAMY_Products.Find(id);
            if (sAMY_Products == null)
            {
                return HttpNotFound();
            }
            return View(sAMY_Products);
        }

        // GET: SAMY_Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SAMY_Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ProdutName,ProductDescription")] SAMY_Products sAMY_Products)
        {
            if (ModelState.IsValid)
            {
                db.SAMY_Products.Add(sAMY_Products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sAMY_Products);
        }

        // GET: SAMY_Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SAMY_Products sAMY_Products = db.SAMY_Products.Find(id);
            if (sAMY_Products == null)
            {
                return HttpNotFound();
            }
            return View(sAMY_Products);
        }

        // POST: SAMY_Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ProdutName,ProductDescription")] SAMY_Products sAMY_Products)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sAMY_Products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sAMY_Products);
        }

        // GET: SAMY_Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SAMY_Products sAMY_Products = db.SAMY_Products.Find(id);
            if (sAMY_Products == null)
            {
                return HttpNotFound();
            }
            return View(sAMY_Products);
        }

        // POST: SAMY_Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SAMY_Products sAMY_Products = db.SAMY_Products.Find(id);
            db.SAMY_Products.Remove(sAMY_Products);
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
