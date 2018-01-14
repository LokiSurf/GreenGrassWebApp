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
    public class TableHistoryRequestsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TableHistoryRequests
        public ActionResult Index()
        {
            return View(db.TableHistoryRequests.ToList());
        }

        // GET: TableHistoryRequests/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableHistoryRequest tableHistoryRequest = db.TableHistoryRequests.Find(id);
            if (tableHistoryRequest == null)
            {
                return HttpNotFound();
            }
            return View(tableHistoryRequest);
        }

        // GET: TableHistoryRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TableHistoryRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,LastName,Team,Manager,TypeReguest,Date,TakenDays,TotalTakenDays,TotalAvailableDays,ReguestStatus")] TableHistoryRequest tableHistoryRequest)
        {
            if (ModelState.IsValid)
            {
                db.TableHistoryRequests.Add(tableHistoryRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tableHistoryRequest);
        }

        // GET: TableHistoryRequests/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableHistoryRequest tableHistoryRequest = db.TableHistoryRequests.Find(id);
            if (tableHistoryRequest == null)
            {
                return HttpNotFound();
            }
            return View(tableHistoryRequest);
        }

        // POST: TableHistoryRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,LastName,Team,Manager,TypeReguest,Date,TakenDays,TotalTakenDays,TotalAvailableDays,ReguestStatus")] TableHistoryRequest tableHistoryRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tableHistoryRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tableHistoryRequest);
        }

        // GET: TableHistoryRequests/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableHistoryRequest tableHistoryRequest = db.TableHistoryRequests.Find(id);
            if (tableHistoryRequest == null)
            {
                return HttpNotFound();
            }
            return View(tableHistoryRequest);
        }

        // POST: TableHistoryRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TableHistoryRequest tableHistoryRequest = db.TableHistoryRequests.Find(id);
            db.TableHistoryRequests.Remove(tableHistoryRequest);
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
