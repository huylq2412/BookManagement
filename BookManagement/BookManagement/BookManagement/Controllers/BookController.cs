using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookManagement.Models;
using PagedList;

namespace BookManagement.Controllers
{
    public class BookController : Controller
    {
        private QLBanSachEntities db = new QLBanSachEntities();
        [Authorize]
        [HttpGet]
        // GET: Book
        public ActionResult Index()
        {
            var sACH = db.SACH.Include(s => s.CHU_DE).Include(s => s.NHA_XUAT_BAN);
            return View(sACH.ToList());
        }

        [HttpPost]
        public ActionResult updateBook(string bookName, string bookCategory)
        {
            //var books = db.SACH.toList();
            var books = db.SACH.Where(p => p.Ten_sach.Contains(bookName) && p.CHU_DE.Ten_chu_de.Contains(bookCategory)).ToList();
            return View("Index",books);
        }
        // GET: Book/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SACH sACH = db.SACH.Find(id);
            if (sACH == null)
            {
                return HttpNotFound();
            }
            return View(sACH);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            ViewBag.Mcd = new SelectList(db.CHU_DE, "Mcd", "Ten_chu_de");
            ViewBag.Mnxb = new SelectList(db.NHA_XUAT_BAN, "Mnxb", "Ten_nha_xuat_ban");
            return View();
        }

        // POST: Book/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ms,Ten_sach,Don_gia,Don_vi_tinh,Mo_ta,Hinh_minh_hoa,Mcd,Mnxb,Ngay_cap_nhat,So_luong_ban,So_lan_xem,so_luong_con")] SACH sACH)
        {
            if (ModelState.IsValid)
            {
                db.SACH.Add(sACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Mcd = new SelectList(db.CHU_DE, "Mcd", "Ten_chu_de", sACH.Mcd);
            ViewBag.Mnxb = new SelectList(db.NHA_XUAT_BAN, "Mnxb", "Ten_nha_xuat_ban", sACH.Mnxb);
            return View(sACH);
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SACH sACH = db.SACH.Find(id);
            if (sACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Mcd = new SelectList(db.CHU_DE, "Mcd", "Ten_chu_de", sACH.Mcd);
            ViewBag.Mnxb = new SelectList(db.NHA_XUAT_BAN, "Mnxb", "Ten_nha_xuat_ban", sACH.Mnxb);
            return View(sACH);
        }

        // POST: Book/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, SACH obj)
        {
            var books = db.SACH.Find(id);
            //SACH objBook = new SACH();
            //objBook.Ten_sach = Request.Form["Ten_sach"];

            books.Ten_sach = Request.Form["Ten_sach"];
            books.Don_gia = Decimal.Parse(Request.Form["Don_gia"]);
            books.Don_vi_tinh = Request.Form["Don_vi_tinh"];
            books.Mo_ta = Request.Form["Mo_ta"];
            books.Hinh_minh_hoa = Request.Form["Hinh_minh_hoa"];
            //books.Mcd = Int32.Parse(Request.Form["Mcd"]);
            //books.Mnxb = Int32.Parse(Request.Form["Mnxb"]);

            db.Entry(books).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SACH sACH = db.SACH.Find(id);
            if (sACH == null)
            {
                return HttpNotFound();
            }
            return View(sACH);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SACH sACH = db.SACH.Find(id);
            db.SACH.Remove(sACH);
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
