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
    public class CaptchaController : Controller
    {
        private CaptchaManagerEntities db = new CaptchaManagerEntities();

        //
        // GET: /Captcha/

        public ActionResult Index()
        {
            var captchas = db.captchas.Include(c => c.imagesComplex).Include(c => c.imagesFormat).Include(c => c.soundsFormat);
            return View(captchas.ToList());
        }

        //
        // GET: /Captcha/Details/5

        public ActionResult Details(int id = 0)
        {
            captchas captchas = db.captchas.Find(id);
            if (captchas == null)
            {
                return HttpNotFound();
            }
            return View(captchas);
        }

        //
        // GET: /Captcha/Create

        public ActionResult Create()
        {
            ViewBag.imageComplex = new SelectList(db.imagesComplex, "id", "description");
            ViewBag.imageFormat = new SelectList(db.imagesFormat, "id", "description");
            ViewBag.soundFormat = new SelectList(db.soundsFormat, "id", "description");
            return View();
        }

        //
        // POST: /Captcha/Create

        [HttpPost]
        public ActionResult Create(captchas captchas)
        {
            if (ModelState.IsValid)
            {
                db.captchas.Add(captchas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.imageComplex = new SelectList(db.imagesComplex, "id", "description", captchas.imageComplex);
            ViewBag.imageFormat = new SelectList(db.imagesFormat, "id", "description", captchas.imageFormat);
            ViewBag.soundFormat = new SelectList(db.soundsFormat, "id", "description", captchas.soundFormat);
            return View(captchas);
        }

        //
        // GET: /Captcha/Edit/5

        public ActionResult Edit(int id = 0)
        {
            captchas captchas = db.captchas.Find(id);
            if (captchas == null)
            {
                return HttpNotFound();
            }
            ViewBag.imageComplex = new SelectList(db.imagesComplex, "id", "description", captchas.imageComplex);
            ViewBag.imageFormat = new SelectList(db.imagesFormat, "id", "description", captchas.imageFormat);
            ViewBag.soundFormat = new SelectList(db.soundsFormat, "id", "description", captchas.soundFormat);
            return View(captchas);
        }

        //
        // POST: /Captcha/Edit/5

        [HttpPost]
        public ActionResult Edit(captchas captchas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(captchas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.imageComplex = new SelectList(db.imagesComplex, "id", "description", captchas.imageComplex);
            ViewBag.imageFormat = new SelectList(db.imagesFormat, "id", "description", captchas.imageFormat);
            ViewBag.soundFormat = new SelectList(db.soundsFormat, "id", "description", captchas.soundFormat);
            return View(captchas);
        }

        //
        // GET: /Captcha/Delete/5

        public ActionResult Delete(int id = 0)
        {
            captchas captchas = db.captchas.Find(id);
            if (captchas == null)
            {
                return HttpNotFound();
            }
            return View(captchas);
        }

        //
        // POST: /Captcha/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            captchas captchas = db.captchas.Find(id);
            db.captchas.Remove(captchas);
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