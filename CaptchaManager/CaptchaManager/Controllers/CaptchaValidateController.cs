using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaManager.DataAccess;
using CaptchaManager.Models;

namespace CaptchaManager.Controllers
{
    public class CaptchaValidateController : Controller
    {

        private CaptchaManagerEntities db = new CaptchaManagerEntities(); 
        //
        // GET: /CaptchaValidate/
        [HttpPost]
        public ActionResult Validate(String userstring)
        {
            
            var searchstring = userstring + ".jpg";
            var captchas = db.captchas.ToList();
            var model = new UserCaptchaModel();
            model.captchas = captchas;


            if (String.IsNullOrEmpty(searchstring))
            {

                model.captchas = db.captchas.Where(x => x.image == searchstring).ToList();
                return View("error");
                
               
            }
            else
            {
                return View("index");
               
            }
            
            

        }

    }
}
