using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaptchaManager.Models
{
    public class SearchModel
    {
        public string SearchText { get; set; }

        public List<CaptchaManager.DataAccess.captchas> captchas { get; set; }

    }
}