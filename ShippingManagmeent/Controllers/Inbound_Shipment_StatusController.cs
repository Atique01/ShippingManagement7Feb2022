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
    public class Inbound_Shipment_StatusController : Controller
    {
        private SAMYEntities db = new SAMYEntities();

        // GET: Inbound_Shipment_Status
        public ActionResult Index()
        {
            return View(db.Inbound_Shipment_Status.ToList());
        }

        // GET: Inbound_Shipment_Status/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inbound_Shipment_Status inbound_Shipment_Status = db.Inbound_Shipment_Status.Find(id);
            if (inbound_Shipment_Status == null)
            {
                return HttpNotFound();
            }
            return View(inbound_Shipment_Status);
        }

        // GET: Inbound_Shipment_Status/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inbound_Shipment_Status/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] Inbound_Shipment_Status inbound_Shipment_Status)
        {
            if (ModelState.IsValid)
            {
                db.Inbound_Shipment_Status.Add(inbound_Shipment_Status);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inbound_Shipment_Status);
        }

        // GET: Inbound_Shipment_Status/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inbound_Shipment_Status inbound_Shipment_Status = db.Inbound_Shipment_Status.Find(id);
            if (inbound_Shipment_Status == null)
            {
                return HttpNotFound();
            }
            return View(inbound_Shipment_Status);
        }

        // POST: Inbound_Shipment_Status/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] Inbound_Shipment_Status inbound_Shipment_Status)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inbound_Shipment_Status).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inbound_Shipment_Status);
        }

        // GET: Inbound_Shipment_Status/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inbound_Shipment_Status inbound_Shipment_Status = db.Inbound_Shipment_Status.Find(id);
            if (inbound_Shipment_Status == null)
            {
                return HttpNotFound();
            }
            return View(inbound_Shipment_Status);
        }

        // POST: Inbound_Shipment_Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inbound_Shipment_Status inbound_Shipment_Status = db.Inbound_Shipment_Status.Find(id);
            db.Inbound_Shipment_Status.Remove(inbound_Shipment_Status);
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
