﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookReadingEvent.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your username")]
        [Display(Name = "User Name")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Please enter your Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password, ErrorMessage = "Please Provide a valid Password")]
        public string password { get; set; }
    }
}
