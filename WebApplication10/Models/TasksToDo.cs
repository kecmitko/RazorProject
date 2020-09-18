using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class TasksToDo
    {
        public int RedenBroj { get; set; }


        [StringLength(100)]
        [Required]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsFinished { get; set; }

        public int?  NumberOfHours { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }


        [CreditCard]
        [Required(ErrorMessage = "Poleto e zadolzitelno!!!")]
        public string Card { get; set; }

    }




}
