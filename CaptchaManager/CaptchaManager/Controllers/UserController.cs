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
    public class UserController : Controller
    {
        private CaptchaManagerEntities db = new CaptchaManagerEntities();

        //
        // GET: /User/

        public ActionResult Index()
        {
            return View(db.users.ToList());
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id = 0)
        {
            users users = db.users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /User/Create

        [HttpPost]
        public ActionResult Create(users users)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(users);
        }

        //
        // GET: /User/Edit/5

        public ActionResult Edit(int id = 0)
        {
            users users = db.users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        public ActionResult Edit(users users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(users);
        }

        //
        // GET: /User/Delete/5

        public ActionResult Delete(int id = 0)
        {
            users users = db.users.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        //
        // POST: /User/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            users users = db.users.Find(id);
            db.users.Remove(users);
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