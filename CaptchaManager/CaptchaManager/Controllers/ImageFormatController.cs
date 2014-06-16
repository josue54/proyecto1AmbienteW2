using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaManager.DataAccess;

namespace CaptchaManager.Controllers
{
    public class ImageFormatController : Controller
    {
        private CaptchaManagerEntities db = new CaptchaManagerEntities();

        //
        // GET: /ImageFormat/

        public ActionResult Index()
        {
            return View(db.imagesFormat.ToList());
        }

        //
        // GET: /ImageFormat/Details/5

        public ActionResult Details(int id = 0)
        {
            imagesFormat imagesformat = db.imagesFormat.Find(id);
            if (imagesformat == null)
            {
                return HttpNotFound();
            }
            return View(imagesformat);
        }

        //
        // GET: /ImageFormat/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ImageFormat/Create

        [HttpPost]
        public ActionResult Create(imagesFormat imagesformat)
        {
            if (ModelState.IsValid)
            {
                db.imagesFormat.Add(imagesformat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(imagesformat);
        }

        //
        // GET: /ImageFormat/Edit/5

        public ActionResult Edit(int id = 0)
        {
            imagesFormat imagesformat = db.imagesFormat.Find(id);
            if (imagesformat == null)
            {
                return HttpNotFound();
            }
            return View(imagesformat);
        }

        //
        // POST: /ImageFormat/Edit/5

        [HttpPost]
        public ActionResult Edit(imagesFormat imagesformat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(imagesformat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(imagesformat);
        }

        //
        // GET: /ImageFormat/Delete/5

        public ActionResult Delete(int id = 0)
        {
            imagesFormat imagesformat = db.imagesFormat.Find(id);
            if (imagesformat == null)
            {
                return HttpNotFound();
            }
            return View(imagesformat);
        }

        //
        // POST: /ImageFormat/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            imagesFormat imagesformat = db.imagesFormat.Find(id);
            db.imagesFormat.Remove(imagesformat);
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