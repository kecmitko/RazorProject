using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.ValidationAttributes
{
    public class DatumValidator : ValidationAttribute
    {
        public string GetErrorMessage1() =>
            $"Please enter end date";


        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var item = (TasksToDo)validationContext.ObjectInstance;


            if (item.IsFinished && item.EndDate == null)
            {
                return new ValidationResult(GetErrorMessage1());
            }

            return ValidationResult.Success;
        }
    }
}
