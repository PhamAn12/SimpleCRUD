using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Students.Models;

namespace Students.Controllers
{
    public class InforsController : Controller
    {
        private dbContext db = new dbContext();

        // GET: Infors
        public ActionResult Index()
        {
            return View(db.Infors.ToList());
        }

        // GET: Infors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Infor infor = db.Infors.Find(id);
            if (infor == null)
            {
                return HttpNotFound();
            }
            return View(infor);
        }

        // GET: Infors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Infors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,StudentName,Age")] Infor infor)
        {
            if (ModelState.IsValid)
            {
                db.Infors.Add(infor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infor);
        }

        // GET: Infors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Infor infor = db.Infors.Find(id);
            if (infor == null)
            {
                return HttpNotFound();
            }
            return View(infor);
        }

        // POST: Infors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,StudentName,Age")] Infor infor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infor);
        }

        // GET: Infors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Infor infor = db.Infors.Find(id);
            if (infor == null)
            {
                return HttpNotFound();
            }
            return View(infor);
        }

        // POST: Infors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Infor infor = db.Infors.Find(id);
            db.Infors.Remove(infor);
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
