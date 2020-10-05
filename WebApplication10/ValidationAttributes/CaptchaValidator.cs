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
            $"The sum of the digits is not 6";
      
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {

            //var numSum = value.ToString(). //"510"
            //   ToCharArray()     //'5','1','0'
            //    .ToList()  //<'5','1','0'>
            //   .Select(x => int.Parse(x.ToString()))
            //   .ToList().Sum();

            var item = (TasksToDo)validationContext.ObjectInstance;
            var charString = item.Captcha.ToString().ToCharArray();
            var sum = 0;
            int i = 0;
            while (i < charString.Length)
            {
                int num = Convert.ToInt32(charString[i]);
                sum += num;
                i++;
                if (sum % 6 == 0)
                    return ValidationResult.Success;
            }
            return new ValidationResult(GetErrorMessage3());
        }
    }
}
