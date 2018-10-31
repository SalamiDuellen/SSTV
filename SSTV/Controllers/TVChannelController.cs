using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SSTV.Models;
using SSTV.Models.TVGuide;

namespace SSTV.Controllers
{
    public class TVChannelController : Controller
    {
        private SSTVContext db = new SSTVContext();

        // GET: TVChannel
        public ActionResult Index()
        {
            return View();
            //return View(db.TVChannels.ToList());
        }

        // GET: TVChannel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TVChannel tVChannel = db.TVChannels.Find(id);
            if (tVChannel == null)
            {
                return HttpNotFound();
            }
            return View(tVChannel);
        }

        // GET: TVChannel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TVChannel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] TVChannel tVChannel)
        {
            if (ModelState.IsValid)
            {
                db.TVChannels.Add(tVChannel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tVChannel);
        }

        // GET: TVChannel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TVChannel tVChannel = db.TVChannels.Find(id);
            if (tVChannel == null)
            {
                return HttpNotFound();
            }
            return View(tVChannel);
        }

        // POST: TVChannel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] TVChannel tVChannel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tVChannel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tVChannel);
        }

        // GET: TVChannel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TVChannel tVChannel = db.TVChannels.Find(id);
            if (tVChannel == null)
            {
                return HttpNotFound();
            }
            return View(tVChannel);
        }

        // POST: TVChannel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TVChannel tVChannel = db.TVChannels.Find(id);
            db.TVChannels.Remove(tVChannel);
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
