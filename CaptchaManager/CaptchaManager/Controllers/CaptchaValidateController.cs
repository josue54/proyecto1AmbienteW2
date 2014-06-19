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

        public ActionResult Validate(String UserString)
        {
            return View();
        }

    }
}
