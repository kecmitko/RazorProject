using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.ValidationAttributes
{
    public class CaptchaValidator : ValidationAttribute
    {
        public string GetErrorMessage3() =>
            $"Incorrect value";


        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var item = (TasksToDo)validationContext.ObjectInstance;

            if (item.Captcha != 6)
            {
                return new ValidationResult(GetErrorMessage3());
            }

            return ValidationResult.Success;
        }
    }
}
