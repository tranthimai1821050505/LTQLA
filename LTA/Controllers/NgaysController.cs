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
    public class NgaysController : Controller
    {
        private LTADbContext db = new LTADbContext();

        // GET: Ngays
        public ActionResult Index()
        {
            return View(db.Ngays.ToList());
        }

        // GET: Ngays/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ngay ngay = db.Ngays.Find(id);
            if (ngay == null)
            {
                return HttpNotFound();
            }
            return View(ngay);
        }

        // GET: Ngays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ngays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NgayThang")] Ngay ngay)
        {
            if (ModelState.IsValid)
            {
                db.Ngays.Add(ngay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ngay);
        }

        // GET: Ngays/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ngay ngay = db.Ngays.Find(id);
            if (ngay == null)
            {
                return HttpNotFound();
            }
            return View(ngay);
        }

        // POST: Ngays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NgayThang")] Ngay ngay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ngay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ngay);
        }

        // GET: Ngays/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ngay ngay = db.Ngays.Find(id);
            if (ngay == null)
            {
                return HttpNotFound();
            }
            return View(ngay);
        }

        // POST: Ngays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ngay ngay = db.Ngays.Find(id);
            db.Ngays.Remove(ngay);
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
