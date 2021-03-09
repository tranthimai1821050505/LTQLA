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
    public class DonThanhToansController : Controller
    {
        private LTADbContext db = new LTADbContext();

        // GET: DonThanhToans
        public ActionResult Index()
        {
            return View(db.DonThanhToans.ToList());
        }

        // GET: DonThanhToans/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonThanhToan donThanhToan = db.DonThanhToans.Find(id);
            if (donThanhToan == null)
            {
                return HttpNotFound();
            }
            return View(donThanhToan);
        }

        // GET: DonThanhToans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonThanhToans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SoPhieuThanhToan,MaDanhMuc,TienDanhMuc,SoDon")] DonThanhToan donThanhToan)
        {
            if (ModelState.IsValid)
            {
                db.DonThanhToans.Add(donThanhToan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(donThanhToan);
        }

        // GET: DonThanhToans/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonThanhToan donThanhToan = db.DonThanhToans.Find(id);
            if (donThanhToan == null)
            {
                return HttpNotFound();
            }
            return View(donThanhToan);
        }

        // POST: DonThanhToans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoPhieuThanhToan,MaDanhMuc,TienDanhMuc,SoDon")] DonThanhToan donThanhToan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donThanhToan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donThanhToan);
        }

        // GET: DonThanhToans/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonThanhToan donThanhToan = db.DonThanhToans.Find(id);
            if (donThanhToan == null)
            {
                return HttpNotFound();
            }
            return View(donThanhToan);
        }

        // POST: DonThanhToans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DonThanhToan donThanhToan = db.DonThanhToans.Find(id);
            db.DonThanhToans.Remove(donThanhToan);
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
