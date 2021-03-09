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
    public class LoaiDanhMucsController : Controller
    {
        private LTADbContext db = new LTADbContext();

        // GET: LoaiDanhMucs
        public ActionResult Index()
        {
            return View(db.LoaiDanhMucs.ToList());
        }

        // GET: LoaiDanhMucs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiDanhMuc loaiDanhMuc = db.LoaiDanhMucs.Find(id);
            if (loaiDanhMuc == null)
            {
                return HttpNotFound();
            }
            return View(loaiDanhMuc);
        }

        // GET: LoaiDanhMucs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiDanhMucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiDanhMuc,TenLoaiDanhMuc,TrangThai")] LoaiDanhMuc loaiDanhMuc)
        {
            if (ModelState.IsValid)
            {
                db.LoaiDanhMucs.Add(loaiDanhMuc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiDanhMuc);
        }

        // GET: LoaiDanhMucs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiDanhMuc loaiDanhMuc = db.LoaiDanhMucs.Find(id);
            if (loaiDanhMuc == null)
            {
                return HttpNotFound();
            }
            return View(loaiDanhMuc);
        }

        // POST: LoaiDanhMucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiDanhMuc,TenLoaiDanhMuc,TrangThai")] LoaiDanhMuc loaiDanhMuc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiDanhMuc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiDanhMuc);
        }

        // GET: LoaiDanhMucs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiDanhMuc loaiDanhMuc = db.LoaiDanhMucs.Find(id);
            if (loaiDanhMuc == null)
            {
                return HttpNotFound();
            }
            return View(loaiDanhMuc);
        }

        // POST: LoaiDanhMucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LoaiDanhMuc loaiDanhMuc = db.LoaiDanhMucs.Find(id);
            db.LoaiDanhMucs.Remove(loaiDanhMuc);
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
