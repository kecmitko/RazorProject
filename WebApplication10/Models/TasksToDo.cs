﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication10.ValidationAttributes;

namespace WebApplication10.Models
{
    public class TasksToDo
    {
        public int RedenBroj { get; set; }


        [StringLength(100)]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }


        [DatumValidator]
        public DateTime? EndDate { get; set; }


        [FinishedValidator]
        public bool IsFinished { get; set; }

        public int?  NumberOfHours { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        [CreditCard]
        public string Card { get; set; }



        // // [Required(ErrorMessage = "Password required")]
        //  [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        //  [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        //  [DataType(DataType.Password)]
        //  [Display(Name = "Password")]
        public string Password { get; set; }

        ////  [Required(ErrorMessage = "Confirm Password required")]
        //  [DataType(DataType.Password)]
        //  [Display(Name = "Confirm Password")]
        //  [Compare("Password", ErrorMessage = "Error : Confirm password does not match with password")]
        public string ConfirmPassword { get; set; }

        [ImNotARobot]
        public int InputValidator { get; set; }

    }




}
