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
    public class Aspnet_MembershipController : Controller
    {
        private SAMYEntities db = new SAMYEntities();

        // GET: Aspnet_Membership
        public ActionResult Index()
        {
            var aspnet_Membership = db.Aspnet_Membership.Include(a => a.Aspnet_Users);
            return View(aspnet_Membership.ToList());
        }

        // GET: Aspnet_Membership/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aspnet_Membership aspnet_Membership = db.Aspnet_Membership.Find(id );
            if (aspnet_Membership == null)
            {
                return HttpNotFound();
            }
            return View(aspnet_Membership);
        }

        // GET: Aspnet_Membership/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Aspnet_Users, "UserId", "UserId");
            return View();
        }

        // POST: Aspnet_Membership/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Password,Email,PasswordQuestion,PasswordAnswer,IsApproved,IsLocked")] Aspnet_Membership aspnet_Membership)
        {
            if (ModelState.IsValid)
            {
                var users = new Aspnet_Users
                {
                    CreationDate = DateTime.Now
                };
                db.Aspnet_Users.Add(users);
                db.SaveChanges();
                var userID = new SelectList(db.Aspnet_Users, "UserId","UserId", users.UserId);
                aspnet_Membership.UserId = Convert.ToInt32(userID.SelectedValue);
               
                db.Aspnet_Membership.Add(aspnet_Membership);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Aspnet_Users, "UserId", "UserId", aspnet_Membership.UserId);
            return View(aspnet_Membership);
        }

        // GET: Aspnet_Membership/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aspnet_Membership aspnet_Membership = db.Aspnet_Membership.Find(id);
            if (aspnet_Membership == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Aspnet_Users, "UserId", "UserId", aspnet_Membership.UserId);
            return View(aspnet_Membership);
        }

        // POST: Aspnet_Membership/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Password,Email,PasswordQuestion,PasswordAnswer,IsApproved,IsLocked,Aspnet_MembershipId")] Aspnet_Membership aspnet_Membership)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aspnet_Membership).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Aspnet_Users, "UserId", "UserId", aspnet_Membership.UserId);
            return View(aspnet_Membership);
        }

        // GET: Aspnet_Membership/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aspnet_Membership aspnet_Membership = db.Aspnet_Membership.Find(id);
            if (aspnet_Membership == null)
            {
                return HttpNotFound();
            }
            return View(aspnet_Membership);
        }

        // POST: Aspnet_Membership/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aspnet_Membership aspnet_Membership = db.Aspnet_Membership.Find(id);
            db.Aspnet_Membership.Remove(aspnet_Membership);
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
