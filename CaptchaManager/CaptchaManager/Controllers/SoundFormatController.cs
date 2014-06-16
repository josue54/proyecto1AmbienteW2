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
    public class SoundFormatController : Controller
    {
        private CaptchaManagerEntities db = new CaptchaManagerEntities();

        //
        // GET: /SoundFormat/

        public ActionResult Index()
        {
            return View(db.soundsFormat.ToList());
        }

        //
        // GET: /SoundFormat/Details/5

        public ActionResult Details(int id = 0)
        {
            soundsFormat soundsformat = db.soundsFormat.Find(id);
            if (soundsformat == null)
            {
                return HttpNotFound();
            }
            return View(soundsformat);
        }

        //
        // GET: /SoundFormat/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SoundFormat/Create

        [HttpPost]
        public ActionResult Create(soundsFormat soundsformat)
        {
            if (ModelState.IsValid)
            {
                db.soundsFormat.Add(soundsformat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(soundsformat);
        }

        //
        // GET: /SoundFormat/Edit/5

        public ActionResult Edit(int id = 0)
        {
            soundsFormat soundsformat = db.soundsFormat.Find(id);
            if (soundsformat == null)
            {
                return HttpNotFound();
            }
            return View(soundsformat);
        }

        //
        // POST: /SoundFormat/Edit/5

        [HttpPost]
        public ActionResult Edit(soundsFormat soundsformat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(soundsformat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(soundsformat);
        }

        //
        // GET: /SoundFormat/Delete/5

        public ActionResult Delete(int id = 0)
        {
            soundsFormat soundsformat = db.soundsFormat.Find(id);
            if (soundsformat == null)
            {
                return HttpNotFound();
            }
            return View(soundsformat);
        }

        //
        // POST: /SoundFormat/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            soundsFormat soundsformat = db.soundsFormat.Find(id);
            db.soundsFormat.Remove(soundsformat);
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