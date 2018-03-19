using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC6_sample.Models;

namespace MVC6_sample.Controllers
{
    public class customerController : Controller
    {
        private stripeEntities2 db = new stripeEntities2();

        // GET: customer
        public ActionResult Index()
        {
            return View(db.tbl_customer.ToList());
        }

        // GET: customer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_customer tbl_customer = db.tbl_customer.Find(id);
            if (tbl_customer == null)
            {
                return HttpNotFound();
            }
            return View(tbl_customer);
        }

        // GET: customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cus_id,name,email,address,dob,createdDate")] tbl_customer tbl_customer)
        {
            if (ModelState.IsValid)
            {
                db.tbl_customer.Add(tbl_customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_customer);
        }

        // GET: customer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_customer tbl_customer = db.tbl_customer.Find(id);
            if (tbl_customer == null)
            {
                return HttpNotFound();
            }
            return View(tbl_customer);
        }

        // POST: customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cus_id,name,email,address,dob,createdDate")] tbl_customer tbl_customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_customer);
        }

        // GET: customer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_customer tbl_customer = db.tbl_customer.Find(id);
            if (tbl_customer == null)
            {
                return HttpNotFound();
            }
            return View(tbl_customer);
        }

        // POST: customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_customer tbl_customer = db.tbl_customer.Find(id);
            db.tbl_customer.Remove(tbl_customer);
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
