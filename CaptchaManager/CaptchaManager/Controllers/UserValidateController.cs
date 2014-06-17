using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaManager.DataAccess;
using CaptchaManager.Models;



namespace CaptchaManager.Controllers
{
    public class UserValidateController : Controller
    {
        private CaptchaManagerEntities db = new CaptchaManagerEntities(); 
        //
        // GET: /UserValidate/

        public ActionResult Index()
        {
            var users = db.users.ToList();
            var model = new UserValidateModel();
            model.users = users;
            return View();
        }


        //
        // POST: /UserValidate/
        [HttpPost]
        public ActionResult Index(UserValidateModel model)
        {

            var findusers = model.SearchUser;
            var captchas = db.captchas.ToList();
            var captchasmodel = new UserCaptchaModel();
            captchasmodel.captchas = captchas;
            Random random = new Random();
            int place;
            if (String.IsNullOrEmpty(findusers))
            {

                captchasmodel.captchas = db.captchas.Where(x => x.imageComplex.Value == 2).ToList();
                
                int randomNumber = random.Next(0,captchasmodel.captchas.Count);
                place = randomNumber;
            }
            else
            {

                
                
                captchasmodel.captchas = db.captchas.Where(x => x.imageComplex.Value==1 ).ToList();
               
                int randomNumber = random.Next(0, captchasmodel.captchas.Count);
                place = randomNumber;
            }
            // return model to the view
            var selectedcaptcha = new CaptchaDisplay();
            selectedcaptcha.captchas = captchasmodel.captchas[place];
            return View("CaptchaValidate",selectedcaptcha);
        }


    }
}
