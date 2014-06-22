using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaptchaManager.Controllers
{
    public class CaptchaValidateController : Controller
    {
        //
        // GET: /CaptchaValidate/
        [HttpPost]
        public ActionResult Validate(String UserString)
        {
            string x = UserString;
            return View("index");
        }

    }
}
