using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearnMVC.ViewModel
{
    public class Auth
    {
        [Required]
        public string username { get; set; }
        [DataType(DataType.Password), Required]
        public string password { get; set; }

    }
}