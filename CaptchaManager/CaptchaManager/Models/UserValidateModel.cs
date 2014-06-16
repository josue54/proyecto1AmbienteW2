using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaptchaManager.Models
{
    public class UserValidateModel
    {
        public string SearchUser { get; set; }
       
        public List<CaptchaManager.DataAccess.users> users { get; set; }
    }
}