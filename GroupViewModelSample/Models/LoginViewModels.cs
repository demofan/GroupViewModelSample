using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupViewModelSample.Models
{
    public class LoginViewModels
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}