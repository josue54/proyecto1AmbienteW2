using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaptchaManager.Models
{
    public class CaptchaDisplay
    {
        public string SelectCaptcha { get; set; }

        public CaptchaManager.DataAccess.captchas captchas { get; set; }

    }
}