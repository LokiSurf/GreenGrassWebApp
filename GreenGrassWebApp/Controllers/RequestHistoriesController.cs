using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GreenGrassWebApp.Models;

namespace GreenGrassWebApp.Controllers
{
    public class RequestHistoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RequestHistories
        public ActionResult Index()
        {
            return View(db.RequestHistories.ToList());
        }

        // GET: RequestHistories/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestHistory requestHistory = db.RequestHistories.Find(id);
            if (requestHistory == null)
            {
                return HttpNotFound();
            }
            return View(requestHistory);
        }

        // GET: RequestHistories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RequestHistories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] RequestHistory requestHistory)
        {
            if (ModelState.IsValid)
            {
                db.RequestHistories.Add(requestHistory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requestHistory);
        }

        // GET: RequestHistories/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestHistory requestHistory = db.RequestHistories.Find(id);
            if (requestHistory == null)
            {
                return HttpNotFound();
            }
            return View(requestHistory);
        }

        // POST: RequestHistories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] RequestHistory requestHistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requestHistory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requestHistory);
        }

        // GET: RequestHistories/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestHistory requestHistory = db.RequestHistories.Find(id);
            if (requestHistory == null)
            {
                return HttpNotFound();
            }
            return View(requestHistory);
        }

        // POST: RequestHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            RequestHistory requestHistory = db.RequestHistories.Find(id);
            db.RequestHistories.Remove(requestHistory);
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
