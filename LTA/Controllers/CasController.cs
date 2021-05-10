using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTA.Models;

namespace LTA.Controllers
{
    public class CasController : Controller
    {
        private LTADbContext db = new LTADbContext();

        // GET: Cas
        public ActionResult Index()
        {
            return View(db.Cas.ToList());
        }

        // GET: Cas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ca ca = db.Cas.Find(id);
            if (ca == null)
            {
                return HttpNotFound();
            }
            return View(ca);
        }

        // GET: Cas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SoCa,Ngay")] Ca ca)
        {
            if (ModelState.IsValid)
            {
                db.Cas.Add(ca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ca);
        }

        // GET: Cas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ca ca = db.Cas.Find(id);
            if (ca == null)
            {
                return HttpNotFound();
            }
            return View(ca);
        }

        // POST: Cas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoCa,Ngay")] Ca ca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ca);
        }

        // GET: Cas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ca ca = db.Cas.Find(id);
            if (ca == null)
            {
                return HttpNotFound();
            }
            return View(ca);
        }

        // POST: Cas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ca ca = db.Cas.Find(id);
            db.Cas.Remove(ca);
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
