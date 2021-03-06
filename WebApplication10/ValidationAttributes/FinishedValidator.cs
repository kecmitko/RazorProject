﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.ValidationAttributes
{
 
    public class FinishedValidator : ValidationAttribute
    {
        public string GetErrorMessage2() =>
            $"Please check Is Finished";

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var item = (TasksToDo)validationContext.ObjectInstance;

            if (!item.IsFinished && item.EndDate != null)
            {
                return new ValidationResult(GetErrorMessage2());
            }

            return ValidationResult.Success;
        }
    }
}
