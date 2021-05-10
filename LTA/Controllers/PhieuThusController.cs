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
    public class PhieuThusController : Controller
    {
        private LTADbContext db = new LTADbContext();

        // GET: PhieuThus
        public async Task<ActionResult> Index()
        {
            return View(await db.PhieuThus.ToListAsync());
        }

        // GET: PhieuThus/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuThu phieuThu = await db.PhieuThus.FindAsync(id);
            if (phieuThu == null)
            {
                return HttpNotFound();
            }
            return View(phieuThu);
        }

        // GET: PhieuThus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhieuThus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SoPhieuThu,MaNhanVien,NgayThang,MaKhachHang,TongTien")] PhieuThu phieuThu)
        {
            if (ModelState.IsValid)
            {
                db.PhieuThus.Add(phieuThu);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(phieuThu);
        }

        // GET: PhieuThus/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuThu phieuThu = await db.PhieuThus.FindAsync(id);
            if (phieuThu == null)
            {
                return HttpNotFound();
            }
            return View(phieuThu);
        }

        // POST: PhieuThus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SoPhieuThu,MaNhanVien,NgayThang,MaKhachHang,TongTien")] PhieuThu phieuThu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phieuThu).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(phieuThu);
        }

        // GET: PhieuThus/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhieuThu phieuThu = await db.PhieuThus.FindAsync(id);
            if (phieuThu == null)
            {
                return HttpNotFound();
            }
            return View(phieuThu);
        }

        // POST: PhieuThus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            PhieuThu phieuThu = await db.PhieuThus.FindAsync(id);
            db.PhieuThus.Remove(phieuThu);
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
