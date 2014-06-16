using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaptchaManager.Models
{
    public class UserCaptchaModel
    {
        public string SearchCaptcha { get; set; }

        public List<CaptchaManager.DataAccess.captchas> captchas { get; set; }

    }
}