using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.ValidationAttributes
{
    public class imNotRobotValidator : ValidationAttribute
    {
        public string GetErrorMessage1() =>
            $"Wrong input";
        

        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var item = (TasksToDo)validationContext.ObjectInstance;
            int chechValArr;

            try
            {
                chechValArr = item.inputValidator.ToString().Select(x => int.Parse(x.ToString())).Sum();
            }
            catch (Exception)
            {
                return new ValidationResult(GetErrorMessage1());
            }

            if (chechValArr != 6)
            {
                return new ValidationResult(GetErrorMessage1());
            }

            return ValidationResult.Success;
        }
    }
}
