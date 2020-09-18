using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10.ValidationAttributes
{
    public class CheckBoxValidatorIsFinished : ValidationAttribute
    {


        public string GetErrorMessage1() =>
            $"Stikliraj go IsFinished.";


        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var item = (TasksToDo)validationContext.ObjectInstance;


            if (item.EndDate != null && !item.IsFinished)
            {
                return new ValidationResult(GetErrorMessage1());
            }

            return ValidationResult.Success;
        }
    }
}

