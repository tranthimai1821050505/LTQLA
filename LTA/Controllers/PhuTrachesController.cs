using System;
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
    public class PhuTrachesController : Controller
    {
        private LTADbContext db = new LTADbContext();

        // GET: PhuTraches
        public async Task<ActionResult> Index()
        {
            return View(await db.PhuTrachs.ToListAsync());
        }

        // GET: PhuTraches/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhuTrach phuTrach = await db.PhuTrachs.FindAsync(id);
            if (phuTrach == null)
            {
                return HttpNotFound();
            }
            return View(phuTrach);
        }

        // GET: PhuTraches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhuTraches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MaNhanVien,SoCa,SoBan")] PhuTrach phuTrach)
        {
            if (ModelState.IsValid)
            {
                db.PhuTrachs.Add(phuTrach);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(phuTrach);
        }

        // GET: PhuTraches/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhuTrach phuTrach = await db.PhuTrachs.FindAsync(id);
            if (phuTrach == null)
            {
                return HttpNotFound();
            }
            return View(phuTrach);
        }

        // POST: PhuTraches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MaNhanVien,SoCa,SoBan")] PhuTrach phuTrach)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phuTrach).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(phuTrach);
        }

        // GET: PhuTraches/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhuTrach phuTrach = await db.PhuTrachs.FindAsync(id);
            if (phuTrach == null)
            {
                return HttpNotFound();
            }
            return View(phuTrach);
        }

        // POST: PhuTraches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            PhuTrach phuTrach = await db.PhuTrachs.FindAsync(id);
            db.PhuTrachs.Remove(phuTrach);
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
