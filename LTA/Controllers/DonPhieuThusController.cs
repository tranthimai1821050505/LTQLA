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
    public class DonPhieuThusController : Controller
    {
        private LTADbContext db = new LTADbContext();

        // GET: DonPhieuThus
        public ActionResult Index()
        {
            return View(db.DonPhieuThus.ToList());
        }

        // GET: DonPhieuThus/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonPhieuThu donPhieuThu = db.DonPhieuThus.Find(id);
            if (donPhieuThu == null)
            {
                return HttpNotFound();
            }
            return View(donPhieuThu);
        }

        // GET: DonPhieuThus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonPhieuThus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SoPhieuThu,MaDanhMuc,TienDanhMuc,DonGiaDanhMuc")] DonPhieuThu donPhieuThu)
        {
            if (ModelState.IsValid)
            {
                db.DonPhieuThus.Add(donPhieuThu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(donPhieuThu);
        }

        // GET: DonPhieuThus/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonPhieuThu donPhieuThu = db.DonPhieuThus.Find(id);
            if (donPhieuThu == null)
            {
                return HttpNotFound();
            }
            return View(donPhieuThu);
        }

        // POST: DonPhieuThus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoPhieuThu,MaDanhMuc,TienDanhMuc,DonGiaDanhMuc")] DonPhieuThu donPhieuThu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donPhieuThu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donPhieuThu);
        }

        // GET: DonPhieuThus/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonPhieuThu donPhieuThu = db.DonPhieuThus.Find(id);
            if (donPhieuThu == null)
            {
                return HttpNotFound();
            }
            return View(donPhieuThu);
        }

        // POST: DonPhieuThus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DonPhieuThu donPhieuThu = db.DonPhieuThus.Find(id);
            db.DonPhieuThus.Remove(donPhieuThu);
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
