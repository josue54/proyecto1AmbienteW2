using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaManager.DataAccess;
using CaptchaManager.Models;

namespace CaptchaManager.Controllers
{
    public class SearchCaptchaController : Controller
    {
        private CaptchaManagerEntities db = new CaptchaManagerEntities();

        //
        // GET: /Search/

        public ActionResult Index()
        {
            // get data from database
            var captchas = db.captchas.ToList();

            // create model
            var model = new SearchModel();

            // fill restaurants in the model
            model.captchas = captchas;

            // return model to the view
            return View(model);
        }

        //
        // POST: /Search/
        [HttpPost]
        public ActionResult Index(SearchModel model)
        {
            var search = model.SearchText;

            if (String.IsNullOrEmpty(search))
            {
                model.captchas = db.captchas.ToList();
            }
            else
            {
                // fill restaurants in the model
                model.captchas = db.captchas.Where(x => x.image.Contains(search)).ToList(); ;
            }
            // return model to the view
            return View(model);
        }

    }
}
