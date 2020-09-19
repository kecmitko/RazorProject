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
            int a = item.Captcha / 10;
            int b = item.Captcha % 10;
            if (a + b == 6)
            {
                return ValidationResult.Success;
            }
                return new ValidationResult(GetErrorMessage3());
    }
}
}
