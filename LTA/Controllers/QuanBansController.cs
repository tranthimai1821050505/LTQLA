﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTA.Models;

namespace LTA.Controllers
{
    public class QuanBansController : Controller
    {
        private LTADbContext db = new LTADbContext();

        // GET: QuanBans
        public async Task<ActionResult> Index()
        {
            return View(await db.QuanBans.ToListAsync());
        }

        // GET: QuanBans/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanBan quanBan = await db.QuanBans.FindAsync(id);
            if (quanBan == null)
            {
                return HttpNotFound();
            }
            return View(quanBan);
        }

        // GET: QuanBans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanBans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MaQuan,TenQuan")] QuanBan quanBan)
        {
            if (ModelState.IsValid)
            {
                db.QuanBans.Add(quanBan);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(quanBan);
        }

        // GET: QuanBans/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanBan quanBan = await db.QuanBans.FindAsync(id);
            if (quanBan == null)
            {
                return HttpNotFound();
            }
            return View(quanBan);
        }

        // POST: QuanBans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MaQuan,TenQuan")] QuanBan quanBan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quanBan).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(quanBan);
        }

        // GET: QuanBans/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanBan quanBan = await db.QuanBans.FindAsync(id);
            if (quanBan == null)
            {
                return HttpNotFound();
            }
            return View(quanBan);
        }

        // POST: QuanBans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            QuanBan quanBan = await db.QuanBans.FindAsync(id);
            db.QuanBans.Remove(quanBan);
            await db.SaveChangesAsync();
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
