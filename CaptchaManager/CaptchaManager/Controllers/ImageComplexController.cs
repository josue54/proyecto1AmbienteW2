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
    public class ImageComplexController : Controller
    {
        private CaptchaManagerEntities db = new CaptchaManagerEntities();

        //
        // GET: /ImageComplex/

        public ActionResult Index()
        {
            return View(db.imagesComplex.ToList());
        }

        //
        // GET: /ImageComplex/Details/5

        public ActionResult Details(int id = 0)
        {
            imagesComplex imagescomplex = db.imagesComplex.Find(id);
            if (imagescomplex == null)
            {
                return HttpNotFound();
            }
            return View(imagescomplex);
        }

        //
        // GET: /ImageComplex/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ImageComplex/Create

        [HttpPost]
        public ActionResult Create(imagesComplex imagescomplex)
        {
            if (ModelState.IsValid)
            {
                db.imagesComplex.Add(imagescomplex);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(imagescomplex);
        }

        //
        // GET: /ImageComplex/Edit/5

        public ActionResult Edit(int id = 0)
        {
            imagesComplex imagescomplex = db.imagesComplex.Find(id);
            if (imagescomplex == null)
            {
                return HttpNotFound();
            }
            return View(imagescomplex);
        }

        //
        // POST: /ImageComplex/Edit/5

        [HttpPost]
        public ActionResult Edit(imagesComplex imagescomplex)
        {
            if (ModelState.IsValid)
            {
                db.Entry(imagescomplex).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(imagescomplex);
        }

        //
        // GET: /ImageComplex/Delete/5

        public ActionResult Delete(int id = 0)
        {
            imagesComplex imagescomplex = db.imagesComplex.Find(id);
            if (imagescomplex == null)
            {
                return HttpNotFound();
            }
            return View(imagescomplex);
        }

        //
        // POST: /ImageComplex/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            imagesComplex imagescomplex = db.imagesComplex.Find(id);
            db.imagesComplex.Remove(imagescomplex);
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