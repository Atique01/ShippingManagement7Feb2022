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
    public class SAMY_ClientController : Controller
    {
        private SAMYEntities db = new SAMYEntities();

        // GET: SAMY_Client
        public ActionResult Index()
        {
            return View(db.SAMY_Client.ToList());
        }

        // GET: SAMY_Client/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SAMY_Client sAMY_Client = db.SAMY_Client.Find(id);
            if (sAMY_Client == null)
            {
                return HttpNotFound();
            }
            return View(sAMY_Client);
        }

        // GET: SAMY_Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SAMY_Client/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ClientName,ClientLocation,CtrateDate,Updatedate")] SAMY_Client sAMY_Client)
        {
            if (ModelState.IsValid)
            {
                db.SAMY_Client.Add(sAMY_Client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sAMY_Client);
        }

        // GET: SAMY_Client/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SAMY_Client sAMY_Client = db.SAMY_Client.Find(id);
            if (sAMY_Client == null)
            {
                return HttpNotFound();
            }
            return View(sAMY_Client);
        }

        // POST: SAMY_Client/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ClientName,ClientLocation,CtrateDate,Updatedate")] SAMY_Client sAMY_Client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sAMY_Client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sAMY_Client);
        }

        // GET: SAMY_Client/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SAMY_Client sAMY_Client = db.SAMY_Client.Find(id);
            if (sAMY_Client == null)
            {
                return HttpNotFound();
            }
            return View(sAMY_Client);
        }

        // POST: SAMY_Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SAMY_Client sAMY_Client = db.SAMY_Client.Find(id);
            db.SAMY_Client.Remove(sAMY_Client);
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
