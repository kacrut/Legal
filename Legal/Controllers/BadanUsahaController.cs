using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Legal.Models;
using System.Data.SqlClient;
using Legal.DTO;
using System.Globalization;

namespace Legal.Controllers
{
    public class BadanUsahaController : Controller
    {
        private LegalMailerContext db = new LegalMailerContext();

        //
        // GET: /BadanUsaha/


        
        public ActionResult Index(string kdkc)
        {
            //return View(db.BUEventLogs.ToList());
            return View();
        }

        public PartialViewResult BuEventLog(Legal.DTO.BranchWeek param)
        {
            var _BUEvent = db.Database.SqlQuery<BUEventLog>("spBUNotification {0}, {1}", param.Cabang, param.Tanggal).OrderBy(a => a.PKSNM);
            return PartialView(_BUEvent);
        }

        public PartialViewResult BuEventLogDetail(int id)
        {
            var polis = db.BUEventLogs.Where(a => a.ID == id).Select(a=>a.NOMOR).SingleOrDefault();
            var _BUEventLogDetail = db.BUEventLogs.Where(a => a.NOMOR == polis).ToList();
            return PartialView(_BUEventLogDetail);
        }

        public PartialViewResult test()
        {
            return PartialView();
        }


        public IEnumerable<BUEventLog> GetBUEventLogByCabang(string kdkc)
        {
            return db.BUEventLogs.Where(a => a.KDKC == kdkc).OrderBy(a=>a.PKSNM).ToList();
        }

        //
        // GET: /BadanUsaha/Details/5

        public ActionResult Details(int id = 0)
        {
            BUEventLog bueventlog = db.BUEventLogs.Find(id);
            if (bueventlog == null)
            {
                return HttpNotFound();
            }
            return View(bueventlog);
        }

        //
        // GET: /BadanUsaha/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BadanUsaha/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BUEventLog bueventlog)
        {
            if (ModelState.IsValid)
            {
                db.BUEventLogs.Add(bueventlog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bueventlog);
        }

        //
        // GET: /BadanUsaha/Edit/5

        public PartialViewResult Edit(int id = 0)
        {
            BUEventLog bueventlog = db.BUEventLogs.Find(id);
            //if (bueventlog == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(bueventlog);
            return PartialView(bueventlog);
        }

        //
        // POST: /BadanUsaha/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BUEventLog bueventlog)
        {
            if (ModelState.IsValid)
            {
                var ID = bueventlog.ID;
                BUEventLog _BUEventLog = null;
                _BUEventLog = db.BUEventLogs.Where(a => a.ID == bueventlog.ID).FirstOrDefault();
                _BUEventLog.KETERANGAN = bueventlog.KETERANGAN;
                _BUEventLog.MODIFIEDDATE = DateTime.Now;
                db.Entry(_BUEventLog).State = EntityState.Modified;
                db.SaveChanges();
                return Content("<script language='javascript' type='text/javascript'>alert('Berhasil Disimpan!');</script>");  
            }
            return Content("<script language='javascript' type='text/javascript'>alert('Gagal Disimpan!');</script>");  
        }

        //
        // GET: /BadanUsaha/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BUEventLog bueventlog = db.BUEventLogs.Find(id);
            if (bueventlog == null)
            {
                return HttpNotFound();
            }
            return View(bueventlog);
        }

        //
        // POST: /BadanUsaha/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BUEventLog bueventlog = db.BUEventLogs.Find(id);
            db.BUEventLogs.Remove(bueventlog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}