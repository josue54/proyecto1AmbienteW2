//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaptchaManager.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class captchas
    {
        public int id { get; set; }
        public string image { get; set; }
        public string sound { get; set; }
        public Nullable<int> soundFormat { get; set; }
        public Nullable<int> imageFormat { get; set; }
        public Nullable<int> imageComplex { get; set; }
    
        public virtual imagesComplex imagesComplex { get; set; }
        public virtual imagesFormat imagesFormat { get; set; }
        public virtual soundsFormat soundsFormat { get; set; }
    }
}
