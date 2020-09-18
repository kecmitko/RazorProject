using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using WebApplication10.Models;

namespace WebApplication10.Validatori.Todo
{
    public class FinishedValidator : ValidationAttribute
    {
   

        public string GetErrorMessage2() =>
            $"Vnesi is finished.";


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


    public class DatumValidator : ValidationAttribute
    {
        public string GetErrorMessage1() =>
            $"Vnesi Datum.";


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
